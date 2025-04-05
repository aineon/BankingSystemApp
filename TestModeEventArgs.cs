using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemApp
{
    public class TestModeEventArgs : EventArgs
    {
        public TestModeEventArgs(bool testMode)
        {
            TestMode = testMode;
        }
        public bool TestMode { get; set; }
    }

    // Publisher Class
    public class TestMode
    {
        public event EventHandler<TestModeEventArgs> ev_TestMode;

        public void CheckTestMode(bool checkTestMode)
        {
            if (checkTestMode)
            {
                OnRaiseTestModeEvent(new TestModeEventArgs(checkTestMode));
            }
        }

        protected virtual void OnRaiseTestModeEvent(TestModeEventArgs e)
        {
            EventHandler<TestModeEventArgs> raiseTestModeEvent = ev_TestMode;

            if (raiseTestModeEvent != null)
            {
                ev_TestMode(this, e);
            }
        }    
    }
}