﻿using FactoryMethodChart.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryMethodChart.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetImageFree()
        {
            ChartProviderFree cp = new ChartProviderFree();
            IChart chart = cp.GetChart();

            chart.Title = "Hours per day";

            List<string> xdata = new List<string>();
            xdata.Add("Mon");
            xdata.Add("Tue");
            xdata.Add("Wed");
            xdata.Add("Thu");
            xdata.Add("Fri");
            xdata.Add("Sat");
            xdata.Add("Sun");

            List<int> ydata = new List<int>();
            ydata.Add(12);
            ydata.Add(7);
            ydata.Add(4);
            ydata.Add(10);
            ydata.Add(3);
            ydata.Add(11);
            ydata.Add(5);

            chart.XData = xdata;
            chart.YData = ydata;
            Bitmap bmp = chart.GenerateChart();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, ImageFormat.Png);
            byte[] data = stream.ToArray();
            stream.Close();
            return File(data, "image/png");
        }



        public ActionResult GetImagePaid()
        {
            ChartProviderPaid cp = new ChartProviderPaid();
            IChart chart = cp.GetChart();

            chart.Title = "Hours per day";

            List<string> xdata = new List<string>();
            xdata.Add("Mon");
            xdata.Add("Tue");
            xdata.Add("Wed");
            xdata.Add("Thu");
            xdata.Add("Fri");
            xdata.Add("Sat");
            xdata.Add("Sun");

            List<int> ydata = new List<int>();
            ydata.Add(12);
            ydata.Add(7);
            ydata.Add(4);
            ydata.Add(10);
            ydata.Add(3);
            ydata.Add(11);
            ydata.Add(5);

            chart.XData = xdata;
            chart.YData = ydata;
            Bitmap bmp = chart.GenerateChart();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, ImageFormat.Png);
            byte[] data = stream.ToArray();
            stream.Close();
            return File(data, "image/png");
        }
    }
}