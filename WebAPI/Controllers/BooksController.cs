using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        [HttpGet("GetBooks")]
        public List<Books> GetBooks()
        {
            List<Books> bookList = new List<Books>();
            DBConnect objDB = new DBConnect();

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllBooks";

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);

            int count = ds.Tables[0].Rows.Count;
           foreach(DataRow title in ds.Tables[0].Rows)
            {
                Books book = new Books();
                book.ISBN = title["ISBN"].ToString();
                book.Title = title["Title"].ToString();
                book.Author = title["Authors"].ToString();
                book.Price = decimal.Parse(title["BasePrice"].ToString());
                book.TotalSales = double.Parse(title["TotalSales"].ToString());
                book.TotalRented = int.Parse(title["TotalQuantityRented"].ToString());
                book.TotalSold = int.Parse(title["TotalQuantitySold"].ToString());
                bookList.Add(book);
            }
            return bookList;

        }

    }
}