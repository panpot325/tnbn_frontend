using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

// ReSharper disable ConvertIfStatementToSwitchStatement
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @Form_Load()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e) {
        Log.WriteLine(@"STEP1: Form1_Load");
        FormPosition();

        /*
        WorkData.Filter._Sno("123-01");
        var dataList = WorkData.GetAll();
        var workData = dataList[0];
        var newData = WorkData.Create();
        SetWorkData(newData, workData, "P");
        newData.SwapLk(5);
        Console.WriteLine($@"after1:  {workData.Lk1} {workData.Lk2} {workData.Lk3} {workData.Lk4} {workData.Lk5} ");
        Console.WriteLine($@"after2:  {newData.Lk1} {newData.Lk2} {newData.Lk3} {newData.Lk4} {newData.Lk5} ");
        */
        
        OptionSet(false);
        _activate = true;
        Mode.SetNew1();
        ViewNameText();
        timer1.Interval = 200;
    }

    /// <summary>
    /// @Form_Activate()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Activated(object sender, EventArgs e) {
        if (!_activate) return;
        _activate = false;

        Log.WriteLine(@"STEP2: Form1_Activated");
        switch (Mode.Value) {
            case Mode.NEW_1 or Mode.NEW_2: //新規 新規2
                Process_New();
                break;
            case Mode.EDIT_1: //船番指定
                Process_Edit();
                break;
            case Mode.COPY_1 or Mode.COPY_2: //船番コピー キーコピー
                Process_Copy();
                break;
        }
    }

    /// <summary>
    /// @Timer1_Timer()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Elapsed(object sender, ElapsedEventArgs e) {
    }

    /// <summary>
    /// Timer_Dmy_Timer()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void timer2_Elapsed(object sender, ElapsedEventArgs e) {
    }

    /// <summary>
    /// @Form_Unload(Cancel As Integer)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
    }

    /// <summary>
    /// Closing Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        Log.Sub_LogWrite("【Form_Unload】");
        PgDump.Dump();
        if (MessageBox.Show(@"終了しますか？",
                @"終了確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
            ) == DialogResult.No) {
            e.Cancel = true;
        }
    }

    /// <summary>
    /// 強制終了　Control | Shift | Alt | C 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == (Keys.Control | Keys.Shift | Keys.Alt | Keys.C)) {
            Environment.Exit(0x8020);
            //Application.Exit();
        }
    }

    private void BackupTest() {
        using var process = new System.Diagnostics.Process();
        var startInfo = new System.Diagnostics.ProcessStartInfo {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
            FileName = "cmd.exe",
           // Arguments = @"set PGPASSWORD=postgres pg_dump -Fc -v --host=localhost --username=postgres --dbname=onozo_202409 -f //Mac/Home/Documents/ONOZO/RiderProjects/Dev\database.dump",
            Arguments = " \"C:\\Program Files\\PostgreSQL\\16\bin\\pg_dump.exe\" -U postgres -d onozo_202502 > database.dump",
            Verb = "RunAs",
            UseShellExecute = true
            
            //set PGPASSWORD=postgres c:\"Program Files\PostgreSQL\16\bin\pg_dump.exe" -d  onozo_202409 > test.sql

        };
        process.StartInfo = startInfo;
        process.Start();
    }

    private void CsvDumpTest() {
        const string sql = "COPY tnbn_kakowk_data  TO '/Users/kyopen/Documents/ONOZO/RiderProjects/Dev/database2.csv' WITH CSV HEADER DELIMITER ',' FORCE QUOTE *;";

        PgOpen.PgDump(sql);
    }
}