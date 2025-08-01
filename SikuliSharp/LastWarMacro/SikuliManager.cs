using SikuliSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWarMacro
{
    public class SikuliManager
    {
        public static readonly string ImgPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\SikuliImages\");
        public static readonly string SikuliPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\Sikuli");

        private static SikuliManager _instance;
        private static readonly object _lock = new object();

        private ISikuliSession _session;

        // 싱글톤 외부 생성 방지
        private SikuliManager()
        {
            Environment.SetEnvironmentVariable("SIKULI_HOME", SikuliPath);
            Console.WriteLine(">> SikuliManager 초기화");
            _session = Sikuli.CreateSession();
        }

        // 전역 인스턴스 접근자
        public static SikuliManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new SikuliManager();
                }
            }
        }

        private string GetFullPath(string path)
        {
            return ImgPath + path;
        }

        public void Click(string imagePath, float similarity = 0.7f)
        {
            var fullPath = GetFullPath(imagePath);

            var pattern = Patterns.FromFile(fullPath, similarity);
            if (_session.Exists(pattern))
            {
                _session.Click(pattern);
                Console.WriteLine($">> 클릭됨: {fullPath}");
            }
            else
            {
                Console.WriteLine($">> 이미지 없음: {fullPath}");
            }
        }

        public void Type(string text)
        {
            _session.Type(text);
            Console.WriteLine($">> 타이핑: {text}");
        }

        public bool Exists(string imagePath, float similarity = 0.7f)
        {
            var pattern = Patterns.FromFile(imagePath, similarity);
            return _session.Exists(pattern);
        }

        public void Dispose()
        {
            _session?.Dispose();
            Console.WriteLine(">> Sikuli 세션 종료");
        }
    }
}
