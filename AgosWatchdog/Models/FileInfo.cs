using System;
using Newtonsoft.Json;

namespace AgosWatchdog
{
    public class FileInfo
    {
        public string FileName { get; set; } //파일 실제 이름
        public string NickName { get; set; } //해당 프로그램 내에서만 사용할 이름
        public string Path { get; set; } //프로그램 경로
        
        public bool StartType { get; set; } //프로세스 등록 후 바로 시작 여부
        public bool Status { get; set; } //현재 프로세스 상태
        public bool IsAutoReStart { get; set; } //프로그램 자동 재시작
        public string Description { get; set; } //설명
        public bool IsPeriodRestart { get; set; } //프로세스 종료시 자동 재시작 여부.
        public int periodIdx { get; set; } //재시작 주기
        public string FileFullName { get; set; }
        public int ProcessID { get; set; } //run 프로세스 id;
        public DateTime LastRunTime { get; set; }
    }
}