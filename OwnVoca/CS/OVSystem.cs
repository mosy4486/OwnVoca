using OwnVoca.FORM;
using System;
using System.Collections.Generic;
using System.Text;

namespace OwnVoca.CS
{
    public class OVSystem : ApplicationContext
    {
        public uint quizIntervalSecond = 60;
        public ushort quizLevel = 1;
        public OVState State { get; private set; } = OVState.Ready;
        private CancellationTokenSource? _cts;
        public QuizForm? _curQF { get; private set; }
        public void Start()
        {
            if (State != OVState.Ready||_cts!=null) return;
            _cts = new CancellationTokenSource();
            _ = StartSystemAsync(_cts.Token);
        }
        private async Task StartSystemAsync(CancellationToken stoppingToken)
        {
            State = OVState.Running;

            await OVDataManager.CheckInitDataAsync(stoppingToken);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    if (_curQF != null)
                    {
                        await Task.Delay(1000, stoppingToken);
                        continue;
                    }
                    bool success = await SpawnQuizAsync(stoppingToken);
                    if (!success)
                    {
                        await Task.Delay(1000, stoppingToken);
                        continue;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(quizIntervalSecond), stoppingToken);
                }
                catch (TaskCanceledException)
                { 
                }
            }

            _cts?.Dispose();
            _cts = null;
            _curQF?.ForceClose();
            _curQF = null;
        }
        //IF Data is Null DataBase Error, Not NetWork, Local, End Program.
        public void Stop()
        { 
            if(State != OVState.Running) return;
            _cts?.Cancel();
            State = OVState.Ready;
        }
        private async Task<bool> SpawnQuizAsync(CancellationToken stoppingToken)
        {
            var data = await OVDataManager.GetRandomWordAsync(quizLevel, stoppingToken);
            if (data == null) return false;

            QuizForm qf = new QuizForm(data);
            qf.FormClosed += (object? s, FormClosedEventArgs a) => _curQF = null;
            qf.StartPosition = FormStartPosition.CenterScreen;
            qf.Show();
            _curQF = qf;
            return true;
        }
    }
}
