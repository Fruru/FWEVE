using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TradeBotEVE
{
    public partial class MainForm : Form
    {
        //globalKeyboardHook gkh = new globalKeyboardHook();
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private static void SendCtrlhotKey(char key)
        {
            keybd_event(0x11, 0, 0, 0);
            keybd_event((byte)key, 0, 0, 0);
            Thread.Sleep(100);
            keybd_event((byte)key, 0, 0x2, 0);
            keybd_event(0x11, 0, 0x2, 0);
        }

        //тонкая настройка (сделать считывание с txt файла!!!)
        int orderRowHeight = 20;                                            // высота строки ордера
        int s = 45;                                                         // расстояние до ордеров от мои ордера
        //int priceinfoX = 30;                    //сдвиг по х для инфо по ценам ордера
        //int priceinfoY = 65;                    //сдвиг по у для инфо по ценам ордера
        //int priceinfoMarketY = 193;             //сдвиг по у для инфо по ценам ордера на рынке
        int AsetsCoordX = 0;                  // "мои ордера" Х
        int AsetsCoordY = 0;                  // "мои ордера" У
        int ShipX = 0;
        int ShipY = 0;
        int undockX = 0;
        int undockY = 0;
        int timeMain = 0;                       // время между действиями
        int timeAdd = 0;                        // рандом
        int orderCount = 0;                     // количество ордеров продажи
        int buyOrderCount = 0;                  // количество ордеров покупки
        int updateOrderCount = 0;               // количество обновлений
        int pricePause = 500;                   //задержка для полчения цены
        int iterPause = 0;                   //задержка для полчения цены
        double errorPrice = 99999999999;
        Thread tradeThread;


        public MainForm()
        {
            InitializeComponent();
            timerGetCursorPos.Start();
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    gkh.HookedKeys.Add(Keys.Escape);
        //    //gkh.HookedKeys.Add(Keys.Escape);
        //    gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        //    //gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        //}

        //void gkh_KeyUp(object sender, KeyEventArgs e)
        //{
        //    System.Environment.Exit(1);
        //    e.Handled = true;
        //}

        //void gkh_KeyDown(object sender, KeyEventArgs e)
        //{
        //    list("Down\t" + e.KeyCode.ToString());
        //    e.Handled = true;
        //    System.Environment.Exit(1);
        //}
        //начало торговли
        private void startBot_Click(object sender, EventArgs e)
        {
            tradeThread = new Thread(startTrade);
            tradeThread.IsBackground = true;
            tradeThread.Start();
        }

        //торговля
        public void startTrade()
        {
            Thread.Sleep(500);
            //считываем переменные с формы
            AsetsCoordX = Convert.ToInt32(AsetsXTextBox.Text);                // "мои ордера" Х
            AsetsCoordY = Convert.ToInt32(AsetsYTextBox.Text);                // "мои ордера" У
            ShipX = Convert.ToInt32(FirstShipXTextBox.Text);
            ShipY = Convert.ToInt32(FirstShipYTextBox.Text);
            undockX = Convert.ToInt32(ChatXTextBox.Text);
            undockY = Convert.ToInt32(ChatYTextBox.Text);
            timeMain = Convert.ToInt32(doTimeMainTextBox.Text);                    // время между действиями
            timeAdd = Convert.ToInt32(doTimeAddTextBox.Text);                      // рандом
            orderCount = Convert.ToInt32(mySellOrderCountTextBox.Text);            // количество ордеров продажи
            buyOrderCount = Convert.ToInt32(myBuyOrderCountTextBox.Text);          // количество ордеров покупки
            updateOrderCount = Convert.ToInt32(iterationCountTextBox.Text);        // количество обновлений
            iterPause = Convert.ToInt32(iterationPauseTextBox.Text);               // количество обновлений
            for (int i = 1; i <= updateOrderCount; i++)
            {
                if (sellCheckBox.Checked)
                {
                    tradeSellCyrcle(timeMain, myOrderCoordX, myOrderCoordY, orderCount);
                }
                if (buyCheckBox.Checked)
                {
                    tradeBuyCyrcle(timeMain, myOrderCoordX, myOrderCoordY,
            myBuyOrderX, myBuyOrderY, buyOrderCount);
                }
                for (int tH = 1; tH <= iterPause;)
                {
                    Thread.Sleep(60000);
                    tH++;
                }
            }

        }
        //прогон по 1 ордеру
        public void tradeSellCyrcle(int pause, int myOrders_X, int myOrders_Y, int orderCount)
        {
            for (int l = 1; l <= orderCount; l++)
            {
                int firstOrderY = 0;                                                //координата Y ордера
                double myOrderPrice = 0;
                double marketOrderPrice = 0;
                moveAndLeftClick(myOrders_X, myOrders_Y, pause);                            //двигаем курсор на мои ордера
                firstOrderY = myOrders_Y + s + orderRowHeight * (l - 1);                        //получаем координату Y ордера
                moveAndLeftClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));            //встаем на ордер в зависимости от номера ордера
                myOrderPrice = getPrice(pricePause);                                        //получаем цену
                rightClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));                  //нажатие правой кнопки
                moveAndLeftClick(myOrders_X + priceinfoX, firstOrderY + priceinfoY,
                    pause + rnd(timeAdd));                                                  //тыкаем на инфо по ценам
                moveAndLeftClick(myOrderCoordX, myOrderCoordY + priceinfoMarketY,
                    pause + rnd(timeAdd));                                                  //тыкаем на первыйы ордер рынка        
                marketOrderPrice = getPrice(pricePause);                                    //получаем цену ордера
                moveAndLeftClick(myOrders_X, myOrders_Y, pause + rnd(timeAdd));             //тыкаем на мои ордера
                moveAndLeftClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));            //на наш ордер
                if (myOrderPrice == getPrice(pricePause))
                {
                    if (myOrderPrice != marketOrderPrice)
                    {
                        double newPrice = marketOrderPrice - 0.01;
                        if (newPrice < errorPrice + 10)
                        {
                            rightClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));
                            moveAndLeftClick(myOrders_X + priceinfoX,
                                firstOrderY + 10, pause + rnd(timeAdd));
                            insertText(newPrice.ToString());
                        }
                        else
                        {
                            list("Ошибочная цена, не удалось преобразовать цену");
                        }
                    }
                }
             }
          }

        public void tradeBuyCyrcle(int pause, int myOrders_X, int myOrders_Y, 
            int buyMarketOrder_X, int buyMarketOrder_Y, int orderCount)
        {
            for (int l = 1; l <= orderCount; l++)
            {
                int firstOrderY = 0;                                                //координата Y ордера
                double myOrderPrice = 0;
                double marketOrderPrice = 0;
                moveAndLeftClick(myOrders_X, myOrders_Y, pause);                            //двигаем курсор на мои ордера
                firstOrderY = buyMarketOrder_Y + orderRowHeight * (l-1);                    //получаем координату Y ордера
                moveAndLeftClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));            //встаем на ордер в зависимости от номера ордера
                myOrderPrice = getPrice(pricePause);                                        //получаем цену
                rightClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));                  //нажатие правой кнопки
                moveAndLeftClick(myOrders_X + priceinfoX, firstOrderY + priceinfoY,
                    pause + rnd(timeAdd));                                                  //тыкаем на инфо по ценам
                moveAndLeftClick(marketBuyOrderX, marketBuyOrderY,
                    pause + rnd(timeAdd));                                                  //тыкаем на первыйы ордер рынка        
                marketOrderPrice = getPrice(pricePause);                                    //получаем цену ордера
                moveAndLeftClick(myOrders_X, myOrders_Y, pause + rnd(timeAdd));             //тыкаем на мои ордера
                moveAndLeftClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));            //на наш ордер
                if (myOrderPrice == getPrice(pricePause))
                {
                    if (myOrderPrice != marketOrderPrice)
                    {
                        double newPrice = marketOrderPrice + 0.01;
                        if (newPrice < errorPrice + 10)
                        {
                            rightClick(myOrders_X, firstOrderY, pause + rnd(timeAdd));
                            moveAndLeftClick(myOrders_X + priceinfoX,
                                firstOrderY + 10, pause + rnd(timeAdd));
                            insertText(newPrice.ToString());
                        }
                        else
                        {
                            list("Ошибочная цена, не удалось преобразовать цену");
                        }
                    }
                }
            }
        }
        //перемещение ккурсора и нажатие левой кнопки мыши
        public void moveAndLeftClick(int x, int y, int p)                           //координаты и время паузы
        {
            Cursor.Position = new Point(x, y);
            Thread.Sleep(p);
            leftClick(x, y, p);                                                     //нажатие правой кнопки

        }
        //нажатие ЛКМ
        public void leftClick(int x, int y, int p)                                  //координаты и время паузы
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);     //нажатие левой кнопки
            Thread.Sleep(p);
        }

        //нажатие ПКМ
        public void rightClick(int x, int y, int p)                                 //координаты и время паузы
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);     //нажатие правой кнопки
            Thread.Sleep(p);
        }

        //копируем чтроку в буфер обмена и вытаскиваем цену
        public double getPrice(int p)
        {
            //Clipboard.Clear();
            string Isk = " ISK";
            string cL = "";
            Thread.Sleep(p);
            SendCtrlhotKey('C');

            var thread2 = new Thread(() => cL = Clipboard.GetText());
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            thread2.Join();
            //cL = Clipboard.GetText().ToString();
            list(cL);
            //cL = "Guidance Disruptor II	75/286	1 485 992,52 ISK	Jita IV - Moon 4 - Caldari Navy Assembly Plant	The Forge	89д 17ч 23мин 29с";
            int lastIndex = cL.IndexOf(Isk);
            int firstIndex = 0;
            double orderPrice = 0;
            /*
            int flag = 0;
            string str = "Станция";
            if (cL.Substring(0, 7).Equals(str))
            {
                for (int i = 0; i <= lastIndex; i++)
                {
                    try
                    {
                        int l = Convert.ToInt32(cL.Substring(i, 1));
                        flag = 1;
                    }
                    catch
                    {
                        if (flag == 1)
                        {
                            firstIndex = i;
                            i = lastIndex;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= lastIndex; i++)
                {
                    if (cL.Substring(i, 1).Equals("/"))
                    {
                        for (int l = i; l <= lastIndex; l++)
                        {
                            if (cL.Substring(l, 1).Equals("	"))
                            {
                                firstIndex = l;
                                i = lastIndex;
                            }
                        }
                    }
                }
            }
            */
            try
            {
                cL = cL.Substring(firstIndex, lastIndex - firstIndex).Trim();  //вычленяем цену из строки и убираем пробелы
            }
            catch
            { }
            list(cL);
            try
            {
                orderPrice = Convert.ToDouble(cL);      //переводим цену в дабл
            }
            catch
            {
                orderPrice = errorPrice;                 //если по какой-то причине не получилось возвращаем это число
            }
            list(orderPrice.ToString());
            return orderPrice;
        }

        
        public void list(string item)
        {
            listBox.Invoke(new Action(() => { listBox.Items.Add(item.ToString());
                listBox.SelectedIndex = listBox.Items.Count - 1;
            }));
        }

        //ввод текста
        public void insertText(string Stroka)
        {
            for (int i = 0; i < Stroka.Length; i++)
            {
                SendKeys.SendWait(Stroka.Substring(i, 1));
                Thread.Sleep(100 + rnd(200));
            }
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");
        }
        private void testButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            SendKeys.SendWait("{.}");
            insertText("9999999,79");
           // double sasd = 99999999999;
        }
        //рандом
        public int rnd(int r)
        {
            Random rnd = new Random();
            return rnd.Next(1, r);
        }
        //получение координат курсора
        private void timerGetCursorPos_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            coordLabelX.Text = x+"";
            coordLabelY.Text = y+"";
        }
    }
}

