using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、做一个添加操作
            //声明一个上下文
            StevenEntities dbContext = new StevenEntities();
            #region 添加操作
            ////操作一个实体类型
            //books book = new books();
            //book.bookName = "ASP.NET";
            //book.publisherID = 1;
            //book.pic = "image/book.jpg";
            //book.price = decimal.Parse("98.6");
            //book.count = 10;
            //book.description = "描述";
            //book.isbn = "1";
            ////告诉上下文对实体进行添加状态
            //dbContext.Entry<books>(book).State = System.Data.EntityState.Added;
            ////对数据进行操作更新数据
            //dbContext.SaveChanges();
            #endregion
            #region 添加操作
            //操作一个实体类型
            //books book = new books();
            //book.bookName = "ASP.NET";
            //book.publisherID = 1;
            //book.pic = "image/book.jpg";
            //book.price = decimal.Parse("98.6");
            //book.count = 10;
            //book.description = "描述";
            //book.isbn = "1";//主键，作为更新和删除的条件（必须注意）
            //告诉上下文对实体进行添加状态
            //修改整行数据操作
            //dbContext.Entry<books>(book).State = System.Data.EntityState.Modified;
            //修改任意一列
            //dbContext.books.Attach(book);//附加操作
            //dbContext.Entry<books>(book).Property<string>(b => b.bookName).IsModified=true;//强类型
            //dbContext.Entry<books>(book).Property<string>("bookName").IsModified = true;//弱类型
            //对数据进行操作更新数据
            //dbContext.SaveChanges();
            #endregion
            #region Linq查询
            var temp=from u in dbContext.books
                     where  u.count>0
                     select u;

            foreach(var user in temp){
                Console.WriteLine(user.isbn+"  "+user.bookName);
              
            }
            #endregion
        }
    }
}
