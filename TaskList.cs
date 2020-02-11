using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Planner
{
    class TaskList
    {
        private Task someTask;
        public void setTask(Task task)
        {
            this.someTask = task;
        }
        public Task getSomeTask()
        {
            return this.someTask;
        }

        public List<Task> list;
        public TaskList()
        {
            this.someTask = new Task();
            this.list = new List<Task>();
        }
        public void addToLissTask()
        {
            String title, body, date, settingDate;
            bool done;
            Console.WriteLine(" | Write a task topic");
            title = Console.ReadLine();

            Console.WriteLine(" | Write the task composition");
            body = Console.ReadLine();

            Console.WriteLine(" | Write the date of the task");
            date = Console.ReadLine();
            done = false;
            //DateTime Whatdate = new DateTime();
            settingDate = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            Console.ReadKey();
            Task newTask = new Task(title, body, date, settingDate, done);
            list.Add(newTask);
        }
        public void lookTasks()
        {
            Console.WriteLine("List of tasks: ");
            foreach (Task t in list)
            {
                Console.WriteLine("________________");
                Task thisTask = new Task(t);
                // try
                //{
                //thisTask = list[i];
                //thisTask = t;
                bool done = thisTask.getDone();
                Console.WriteLine(t.getSubject());
                Console.WriteLine(t.getData());
                Console.WriteLine(t.getDate());
                Console.WriteLine(t.getSettingDate());
                if (done)
                {
                    Console.WriteLine("The task is done");
                }
                else
                {
                    Console.WriteLine("Assignment not yet completed");
                }

                Console.WriteLine("________________");
                //}

                //catch (Exception e)
                //{
                //  Console.WriteLine(e.Message);
                //}
            }
            Console.ReadKey();
        }
        public void deleteTask()
        {
            String title;
            Console.WriteLine(" | If you want to delete a Task you must write a subject of task:");
            title = Console.ReadLine();
            try
            {
                foreach (Task t in list)
                {

                    String contains = t.getSubject();
                    if (title.Equals(contains))
                    {
                        list.Remove(t);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(" | If you want to delete all done task enter the <true> : ");
            String done = Console.ReadLine();
            if (done.Equals("true"))
            {
                try
                {
                    foreach (Task t in list)
                    {
                        bool contains = t.getDone();
                        if (contains)
                        {
                            list.Remove(t);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public void writeListToFile()
        {
            try
            {
                string fileName = "out.txt";
                FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate| FileMode.Truncate);
                StreamWriter sw = new StreamWriter(aFile);
                sw.Flush();
                aFile.Seek(0, SeekOrigin.End);
                try
                {
                    foreach (Task t in list)
                    {
                        sw.WriteLine(t.getSubject());
                        sw.WriteLine(t.getData());
                        sw.WriteLine(t.getDate());
                        sw.WriteLine(t.getSettingDate());
                        sw.WriteLine(t.getDone());
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void readListFromFile()
        {
            string fileName = "out.txt";
            
            int oneTaskMember = 0;

            StreamReader sr = new StreamReader("out.txt");
            string line;
            while (!sr.EndOfStream)
            {
                Task newTask = new Task();
                newTask.setSubject(sr.ReadLine());
                newTask.setData(sr.ReadLine());
                newTask.setDate(sr.ReadLine());
                newTask.setSettingDate(sr.ReadLine());
                line = sr.ReadLine();
                if (line.Equals("True"))
                {
                    newTask.setDone(true);
                }
                if (line.Equals("False"))
                {
                    newTask.setDone(false);
                }
                oneTaskMember = 0;
                list.Add(newTask);
                //
                /*line = sr.ReadLine();
                Console.WriteLine(line);
                if (oneTaskMember == 0)
                {
                    newTask.setSubject(line);
                    oneTaskMember++;
                }
                if (oneTaskMember == 1)
                {
                    newTask.setData(line);
                    oneTaskMember++;
                }
                if (oneTaskMember == 2)
                {
                    newTask.setDate(line);
                    oneTaskMember++;
                }
                if (oneTaskMember == 3)
                {
                    newTask.setSettingDate(line);
                    oneTaskMember++;
                }
                if (oneTaskMember == 4)
                {
                    if (line.Equals("True"))
                    {
                        newTask.setDone(true);
                    }
                    if (line.Equals("False"))
                    {
                        newTask.setDone(false);
                    }
                    oneTaskMember = 0;
                    list.Add(newTask);
                }*/
            }
            sr.Close();

            /* using (StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default))
             {
                 string line;
                 while ((line = sr.ReadLine()) != null)
                 {
                     if (oneTaskMember == 0)
                     {
                         newTask.setSubject(line);
                         oneTaskMember++;
                     }
                     if (oneTaskMember == 1)
                     {
                         newTask.setData(line);
                         oneTaskMember++;
                     }
                     if (oneTaskMember == 2)
                     {
                         newTask.setDate(line);
                         oneTaskMember++;
                     }
                     if (oneTaskMember == 3)
                     {
                         newTask.setSettingDate(line);
                         oneTaskMember++;
                     }
                     if (oneTaskMember == 4)
                     {
                         if (line.Equals("True")) {
                             newTask.setDone(true);
                         }
                         if (line.Equals("False"))
                         {
                             newTask.setDone(false);
                         }
                         oneTaskMember = 0;
                         list.Add(newTask);
                     }

                 }
             }*/
            Console.ReadKey();
        }
        public void changeTask()
        {
            String title;
            String body, date;
            bool done;
            String yesNo;

            Console.WriteLine(" | If you want to change a Task you must write a subject of task:");
            title = Console.ReadLine();
            try
            {
                foreach (Task t in list)
                {
                    String contains = t.getSubject();
                    if (title.Equals(contains))
                    {
                        Console.WriteLine(" | Make change task composition? - Y/N");
                        yesNo = Console.ReadLine();
                        if (yesNo.Equals("Y")) {
                            Console.WriteLine(" | Write the task composition");
                            body = Console.ReadLine();
                            t.setData(body);
                        }
                        Console.WriteLine(" | Make change task date? - Y/N");
                        yesNo = Console.ReadLine();
                        if (yesNo.Equals("Y"))
                        {
                            Console.WriteLine(" | Write the date of the task");
                            date = Console.ReadLine();
                            t.setDate(date);
                        }
                        Console.WriteLine(" | The task is done? - Y/N");
                        yesNo = Console.ReadLine();
                        if (yesNo.Equals("Y"))
                        {
                            t.setDone(true);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void lookNoDoneTasks()
        {
            Console.WriteLine("List of tasks: ");
            foreach (Task t in list)
            {
                Console.WriteLine("________________");
                Task thisTask = new Task(t);
                // try
                //{
                //thisTask = list[i];
                //thisTask = t;
                bool done = thisTask.getDone();
                if (!done) { 
                Console.WriteLine(t.getSubject());
                Console.WriteLine(t.getData());
                Console.WriteLine(t.getDate());
                Console.WriteLine(t.getSettingDate());
                if (done)
                {
                    Console.WriteLine("The task is done");
                }
                else
                {
                    Console.WriteLine("Assignment not yet completed");
                }

                Console.WriteLine("________________");
                //}

                //catch (Exception e)
                //{
                //  Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
        public void taskOnDate()
        {

            Console.WriteLine("Enter the date in the specified form like (DD.MM.YYYY) ");
            Console.WriteLine("List of tasks: ");
            String thisDate = Console.ReadLine();
            String taskDate;
            foreach (Task t in list)
            {
                taskDate = t.getDate();
                if (taskDate.Equals(thisDate))
                {
                    Console.WriteLine("________________");
                    Task thisTask = new Task(t);
                    bool done = thisTask.getDone();
                    Console.WriteLine(t.getSubject());
                    Console.WriteLine(t.getData());
                    Console.WriteLine(t.getDate());
                    Console.WriteLine(t.getSettingDate());
                    if (done)
                    {
                        Console.WriteLine("The task is done");
                    }
                    else
                    {
                        Console.WriteLine("Assignment not yet completed");
                    }

                    Console.WriteLine("________________");
                }
            }
            Console.ReadKey();

        }
    }

}
