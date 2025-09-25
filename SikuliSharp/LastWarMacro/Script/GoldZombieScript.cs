using Microsoft.VisualBasic.Devices;
using System;
using System.Threading;
using System.Threading.Tasks;
using SikuliSharp;

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
                for (int i = 0; i < 10000; i++)
                {
                    try
                    {
                        LogManager.Instance.WriteLog($"[GoldZombieScript] {i + 1}/1000 회차 실행 중...");
                        await RunScriptAsync(token);
                    }
                    catch (Exception e)
                    {
                        LogManager.Instance.WriteLog("중단됨 다시 시작");
                        Escape();
                        await Task.Delay(10000, token);
                        continue;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                LogManager.Instance.WriteLog("중단 되었습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Stop()
        {
            _cts?.Cancel();
        }

        private void Escape()
        {
            if (WindowHelper.FocusProcess("LastWar"))
            {
                System.Threading.Thread.Sleep(200); // 포커스 안정화 대기
                KeyboardInput.SendEsc();
                Console.WriteLine("ESC 키 전송 완료");
            }
            else
            {
                Console.WriteLine("대상 프로세스를 찾을 수 없음");
            }
        }

        private async Task RunScriptAsync(CancellationToken token)
        {
            LogManager.Instance.WriteLog("특별 이벤트 클릭");
            await ClickAndDelayAsync(Consts.IMG_SPECIAL_EVENT, 1000, token);

            LogManager.Instance.WriteLog("검색 클릭");
            await ClickAndDelayAsync(Consts.IMG_SEARCH_BUTTON, 1000, token);


            LogManager.Instance.WriteLog("칼 버튼 클릭");
            await ClickAndDelayAsync(Consts.IMG_SWORD_ICON, 1000, token);

            await HandleRecoveryAsync(1000, token);

            LogManager.Instance.WriteLog("출정 버튼 클릭");
            await ClickAndDelayAsync(Consts.IMG_DEPLOY, 1000, token);

            LogManager.Instance.WriteLog("30초 대기");
            await Task.Delay(30000, token); // 마지막 대기
        }

        private async Task ClickAndDelayAsync(string imagePath, int delayMs, CancellationToken token)
        {
            SikuliManager.Instance.Click(imagePath);
            await Task.Delay(delayMs, token);
        }

        private async Task HandleRecoveryAsync(int delayMs, CancellationToken token)
        {
            LogManager.Instance.WriteLog("회복 버튼 있는지 검사");
            if (!SikuliManager.Instance.Exists(Consts.IMG_RECOVER))
            {
                LogManager.Instance.WriteLog("회복 버튼 없음");
                return;
            }

            LogManager.Instance.WriteLog("회복 버튼 클릭");
            await ClickAndDelayAsync(Consts.IMG_RECOVER, delayMs, token);

            LogManager.Instance.WriteLog("사용 클릭");
            await ClickAndDelayAsync(Consts.IMG_USE, delayMs, token);

            LogManager.Instance.WriteLog("X 버튼 클릭");
            await ClickAndDelayAsync(Consts.IMG_CLOSE, delayMs, token);
        }
    }
}
