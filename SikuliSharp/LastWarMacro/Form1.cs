using LastWarMacro.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastWarMacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // LogManager에 로그 출력 함수 등록
            LogManager.Instance.RegisterLogAction(LogToTextResult);
        }

        // 로그 메시지를 textResult에 출력하는 메소드
        private void LogToTextResult(string message)
        {
            // UI 스레드에서 안전하게 텍스트 업데이트
            if (textResult.InvokeRequired)
            {
                textResult.Invoke(new Action<string>(LogToTextResult), message);
                return;
            }

            // 기존 텍스트에 새 로그 추가 (줄바꿈 포함)
            if (!string.IsNullOrEmpty(textResult.Text))
            {
                textResult.Text += Environment.NewLine;
            }
            textResult.Text += message;

            // 스크롤을 맨 아래로 이동
            textResult.SelectionStart = textResult.Text.Length;
            textResult.ScrollToCaret();
        }

        private void GoldZombieStartButton_Click(object sender, EventArgs e)
        {
            ScriptManager.Instance.Run(ScriptType.GOLD_ZOMBIE);
        }

        private void GoldZombieStopButton_Click(object sender, EventArgs e)
        {
            ScriptManager.Instance.Stop();
        }

        private void MissionStartButton_Click(object sender, EventArgs e)
        {
            ScriptManager.Instance.Run(ScriptType.MISSION_FIND);
        }

        private void MissionStopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
