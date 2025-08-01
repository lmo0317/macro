using System;
using System.Threading;
using System.Threading.Tasks;

namespace LastWarMacro.Script
{
    public class GoldZombieScript : IScript
    {
        private CancellationTokenSource _cts;

        public async void Run()
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"[GoldZombieScript] {i + 1}/10회차 실행 중...");
                    await RunScriptAsync(token);
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("GoldZombieScript: 작업이 중단되었습니다.");
            }
        }

        public void Stop()
        {
            _cts?.Cancel();
        }

        private async Task RunScriptAsync(CancellationToken token)
        {
            await ClickAndDelayAsync(Consts.IMG_SPECIAL_EVENT, 1000, token);
            await ClickAndDelayAsync(Consts.IMG_SEARCH_BUTTON, 1000, token);
            await ClickAndDelayAsync(Consts.IMG_SWORD_ICON, 1000, token);

            await HandleRecoveryAsync(1000, token);

            await ClickAndDelayAsync(Consts.IMG_DEPLOY, 1000, token);
            await Task.Delay(30000, token); // 마지막 대기
        }

        private async Task ClickAndDelayAsync(string imagePath, int delayMs, CancellationToken token)
        {
            SikuliManager.Instance.Click(imagePath);
            await Task.Delay(delayMs, token);
        }

        private async Task HandleRecoveryAsync(int delayMs, CancellationToken token)
        {
            if (!SikuliManager.Instance.Exists(Consts.IMG_RECOVER))
                return;

            await ClickAndDelayAsync(Consts.IMG_RECOVER, delayMs, token);

            if (SikuliManager.Instance.Exists(Consts.IMG_USE))
            {
                await ClickAndDelayAsync(Consts.IMG_USE, delayMs, token);
            }

            await ClickAndDelayAsync(Consts.IMG_CLOSE, delayMs, token);
        }
    }
}
