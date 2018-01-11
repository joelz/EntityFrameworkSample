using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLogger.Model;

namespace TimeLogger.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 建库
            /*

            //建库：第一种写法
            if (!Database.Exists("Name=TLDbContext")) {
                using (var ctx = new TLDbContext())
                {
                    //create a database explicitly 
                    ctx.Database.Create();
                }
            }

            //建库：第二种写法
            using (var ctx = new TLDbContext())
            {
                //will create the database if it doesn’t already exist 
                var wasCreated = ctx.Database.CreateIfNotExists();
                System.Console.WriteLine(wasCreated ? "created!" : "creation failed.");
            }

            */
            #endregion

            using (var ctx = new TLDbContext())
            {
                //生成建库脚本
                //var octx = (ctx as IObjectContextAdapter).ObjectContext;
                //File.WriteAllText("TLDbContext.sql", octx.CreateDatabaseScript());

                //更新数据
                //ctx.Projects.AddOrUpdate(x => x.Name, 
                //    new Project { Name = "First Project", Start = new DateTime(2018, 01, 01) }
                //    );
                //for (int i = 1; i<100; i++) {
                //    ctx.Customers.AddOrUpdate(x => x.Name, new Customer { Name = "Big Customer " + i.ToString() });
                //}
                //ctx.SaveChanges();

                System.Console.WriteLine(ctx.Projects.Find(2).Name);
            }


            System.Console.Read();
        }
    }
}
