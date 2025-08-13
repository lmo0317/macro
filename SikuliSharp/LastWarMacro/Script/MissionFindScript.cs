using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LastWarMacro.Script
{
    public class MissionFindScript : IScript
    {
        private CancellationTokenSource _cts;

        public void Run()
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            try
            {
                while (true)
                {
                    if (SikuliManager.Instance.Exists(Consts.IMG_MISSION_UR_LEVEL5))
                    {
                        SikuliManager.Instance.Click(Consts.IMG_MISSION_UR_LEVEL5);
                        return;
                    }

                    SikuliManager.Instance.DragDrop();
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("MissionFindScript: 작업이 중단되었습니다.");
            }
            catch (Exception)
            {
                //await Type(Key.ESC, 1000, token);
            }
        }

        public void Stop()
        {
            _cts?.Cancel();
        }
    }
}
