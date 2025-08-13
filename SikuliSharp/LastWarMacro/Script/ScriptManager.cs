using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWarMacro.Script
{
    public enum ScriptType
    {
        GOLD_ZOMBIE,
        MISSION_FIND,
    }

    public class ScriptManager
    {
        private static ScriptManager _instance;
        private static readonly object _lock = new object();

        private IScript _script;

        private ScriptManager()
        {
        }

        // 전역 인스턴스 접근자
        public static ScriptManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new ScriptManager();
                }
            }
        }

        public void Run(ScriptType type)
        {
            // 로그 출력 메소드
            LogManager.Instance.WriteLog($"스크립트 시작: {type}");

            switch(type)
            {
                case ScriptType.GOLD_ZOMBIE:
                    _script = new GoldZombieScript();
                    break;
                case ScriptType.MISSION_FIND:
                    _script = new MissionFindScript();
                    break;
            }

            _script.Run();
        }

        public void Stop()
        {
            _script.Stop();
        }
    }
}
