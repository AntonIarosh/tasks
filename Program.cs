using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TaskList listing = new TaskList();
            do
            {
                
                /* listing.addToLissTask();
                 listing.addToLissTask();
                 listing.lookTasks();
                 listing.writeListToFail();*/


                Console.Clear();
                //Выводим меню, его пункты с соответствующими цифрами\символами
                Console.WriteLine("### MENU ###");
                Console.WriteLine("1. Добавление новой задачи в список задач");
                Console.WriteLine("2. Просмотр списка задач");
                Console.WriteLine("3. Удаление задачи по исходя из темы задачи");
                Console.WriteLine("4. Редактировать выбранную по теме задачу ");
                Console.WriteLine("5. Записать в файл список ");
                Console.WriteLine("6. Загрузить список задач из файла ");
                Console.WriteLine("7. Просмотреть не законченные задачи");
                Console.WriteLine("8. Просмотреть задачи на нужную дату");
                Console.WriteLine("9. Exit");
                Console.Write("\n" + "Введите команду: ");

                char ch = char.Parse(Console.ReadLine());
                if (ch.Equals("7"))
                {
                    break;
                }
                switch (ch)
                {
                    case '1':
                        {
                            listing.addToLissTask();
                            break;
                        }
                    case '2':
                        {
                            listing.lookTasks();
                            break;
                        }
                    case '3':
                        {
                            listing.deleteTask();
                            break;
                        }
                    case '4':
                        {
                            listing.changeTask();
                            break;
                        }
                    case '5':
                        {
                            listing.writeListToFile();
                            break;
                        }
                    case '6':
                        {
                            listing.readListFromFile();
                            break;
                        }
                    case '7':
                        {
                            listing.lookNoDoneTasks();
                            break;
                        }
                    case '8':
                        {
                            listing.taskOnDate();
                            break;
                        }
                    case '9':
                        {
                            return;
                            break;
                        }

                }
            } while (true);
            Console.ReadKey();
        }
    }
}
