using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;

namespace OwnVoca.CS
{
    public static class OVDataManager
    {
        private static HttpClient hc = new HttpClient();
        private static WordData[]? wordDatas;
        public static async Task<bool> CheckInitDataAsync(CancellationToken token)
        {
            if (wordDatas == null || wordDatas.Length == 0)
            {
                WordData[]? datas = await InitDataAsync(token);
                if (datas == null)
                {
                    wordDatas = null;
                    return false;
                }
                wordDatas = datas;
            }
            return true;
        }
        private static async Task<WordData[]?> InitDataAsync(CancellationToken stoppingToken)
        {
            string path = @"C:\Users\pc\source\repos\OwnVoca\OwnVoca\Data\OVDATABASE.txt";
            string[] lines = await File.ReadAllLinesAsync(path,stoppingToken);

            List<WordData> wds = new List<WordData>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(" ",3);
                if (data.Length != 3) continue;
                //Data Base's Idxs start with 1
                ushort level;
                if (!ushort.TryParse(data[0], out level)) continue;
                int idx;
                if(!int.TryParse(data[1],out idx)) continue;
                string word = data[2];

                WordData wordData = new WordData(level,idx,word);
                wds.Add(wordData);
            }

            return wds.Count > 0 ? wds.ToArray() : null;
        }
        //if data is null, try Init Data by DataBase once, If Failed, return null(fail)
        public static async Task<WordData?> GetRandomWordAsync(ushort level, CancellationToken stoppingToken)
        {
            if (!await CheckInitDataAsync(stoppingToken)) return null;

            int plidx = wordDatas.Where(d => d._level == level - 1).ToArray().Length;
            int clidx = wordDatas.Where(d => d._level == level).ToArray().Length;
            int ridx = Random.Shared.Next(plidx, clidx + plidx);
            WordData result = wordDatas[ridx];
            string[]? mr = await LoadMeaningAsync(result._word, stoppingToken);
            if (mr == null||mr.Length<=0) return null;
            result.meaning = mr;
            result.InitWordData();

            return result;
        }

        private static async Task<string[]?> LoadMeaningAsync(string word,CancellationToken stoppingToken)
        {
            string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(word)}&langpair=en|ko";
            List<string> meaning = new List<string>();
            try
            {
                string jsonString = await hc.GetStringAsync(url, stoppingToken);
                using JsonDocument jsonDoc = JsonDocument.Parse(jsonString);
                //Main Trans
                string? mm = jsonDoc.RootElement.GetProperty("responseData").GetProperty("translatedText").GetString();
                if (mm == null || string.IsNullOrWhiteSpace(mm)) return null;
                meaning.Add(mm);

                JsonElement matches = jsonDoc.RootElement.GetProperty("matches");

                foreach (var m in matches.EnumerateArray())
                {
                    string? w = m.GetProperty("segment").GetString();
                    string? translation = m.GetProperty("translation").GetString();

                    if (!string.Equals(w?.Trim(), word.Trim(),
                        StringComparison.OrdinalIgnoreCase))
                        continue;

                    if (!string.IsNullOrWhiteSpace(translation) &&
                        !meaning.Contains(translation))
                    {
                        if (translation.Any(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                        {
                            continue;
                        }
                        meaning.Add(translation);
                    }
                }
            }
            catch (HttpRequestException)
            {
            }
            catch (HttpIOException)
            {
            }
            catch (JsonException)
            {
            }
            catch (KeyNotFoundException)
            {
            }

            return meaning.ToArray();
        }


    }
}
