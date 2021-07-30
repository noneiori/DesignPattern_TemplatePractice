using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TemplatePractice
{
    public abstract class Strategy
    {
        /// <summary>
        /// 交易實行
        /// </summary>
        public void execute()
        {
            GetKLineDatas();
            SaveKLineToDataBase();
            var sign = CheckSign();
            if (sign != TradeSign.NonSign)
            {
                OrderSend(sign);
            }
            MarketOrderSend();
        }
        /// <summary>
        /// 送出停損單
        /// </summary>
        private void MarketOrderSend()
        {
            Console.WriteLine("Send Market Stop Order!");
        }
        /// <summary>
        /// 依照訊號下單
        /// </summary>
        /// <param name="sign"></param>
        private void OrderSend(TradeSign sign)
        {
            Console.WriteLine("Send Order:"+sign.ToString());
        }
        /// <summary>
        /// 檢查訊號
        /// </summary>
        /// <returns></returns>
        protected abstract TradeSign CheckSign();

        /// <summary>
        /// 匯入資料進資料庫
        /// </summary>
        private void SaveKLineToDataBase()
        {
            Console.WriteLine("Save data to database");
        }

        /// <summary>
        /// 取得k線資料
        /// </summary>
        private void GetKLineDatas()
        {
            Console.WriteLine("Get Data from API");
        }
    }

    public enum TradeSign
    {
        /// <summary>
        /// 買入訊號
        /// </summary>
        Buy,
        /// <summary>
        /// 賣出訊號
        /// </summary>
        Sell,
        /// <summary>
        /// 沒有訊號
        /// </summary>
        NonSign
    }
}
