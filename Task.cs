using System;
using System.Collections.Generic;
using System.Text;

namespace Planner
{
    class Task
    {

        private String subject;
        private String data;
        private String date;
        private bool itsDone;
        private String taskSettingDate;
        public void setSubject(String subj)
        {
            this.subject = subj;

        }
        public void setSettingDate(String settingDate)
        {
            this.taskSettingDate = settingDate;

        }
        public void setData(String about)
        {
            this.data = about;

        }
        public void setDate(String when)
        {
            this.date = when;

        }
        public void setDone(bool done)
        {
            this.itsDone = done;

        }
        public String getSubject()
        {
            return this.subject;
        }

        public String getData()
        {
            return this.data;
        }
        public String getDate()
        {
            return this.date;
        }
        public bool getDone()
        {
            return this.itsDone;
        }
        public String getSettingDate()
        {
            return this.taskSettingDate;
        }
        public Task()
        {
            this.data = "";
            this.date = "";
            this.itsDone = false;
            this.subject = "";
            this.taskSettingDate = "";
        }
        public Task(Task t)
        {
            this.data = t.getData(); 
            this.date = t.getDate();
            this.itsDone = t.getDone();
            this.subject = t.getSubject();
            this.taskSettingDate = t.getSettingDate();
        }
        public Task(String subj, String main, String when, String SeetinDate, bool done)
        {
            this.data = main;
            this.date = when;
            this.itsDone = done;
            this.subject = subj;
            this.taskSettingDate = SeetinDate;
        }
    }
}
