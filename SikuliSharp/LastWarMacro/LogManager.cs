using System;

namespace LastWarMacro
{
    public class LogManager
    {
        private static LogManager _instance;
        private static readonly object _lock = new object();

        // 로그 출력을 위한 델리게이트
        private Action<string> _logAction;

        private LogManager()
        {
        }

        // 전역 인스턴스 접근자
        public static LogManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new LogManager();
                }
            }
        }

        // 로그 출력 함수 등록
        public void RegisterLogAction(Action<string> logAction)
        {
            _logAction = logAction;
        }

        // 로그 출력 메소드
        public void WriteLog(string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            _logAction?.Invoke(logMessage);
        }

        // 로그 출력 함수 해제
        public void UnregisterLogAction()
        {
            _logAction = null;
        }
    }
}
