using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace AgosWatchdog
{
    public enum ProcState : short
    {
        [Description ("알 수 없음")]unknown = -1,
        [Description("중지됨")] terminated,
        [Description("실행 중")] running,
        [Description("응답 없음")] hang
    }
    public class FileInfo
    {
        public string FileName { get; set; } //파일 실제 이름
        public string NickName { get; set; } //해당 프로그램 내에서만 사용할 이름
        public string Path { get; set; } //프로그램 경로
        public bool Pause { get; set; }
        public bool StartType { get; set; } //프로세스 등록 후 바로 시작 여부
        public ProcState State { get; set; } //현재 프로세스 상태
        public bool IsAutoReStart { get; set; } //프로그램 자동 재시작
        public string Description { get; set; } //설명
        public bool IsPeriodRestart { get; set; } //프로세스 종료시 자동 재시작 여부.
        public int periodIdx { get; set; } //재시작 주기
        public string FileFullName { get; set; }
        public int ProcessID { get; set; } //run 프로세스 id;
        public DateTime LastRunTime { get; set; }
    }
}