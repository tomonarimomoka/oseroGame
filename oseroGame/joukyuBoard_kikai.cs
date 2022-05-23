using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oseroGame
{
    public partial class joukyuBoard_kikai : BaseBoardForm
    {
        public joukyuBoard_kikai()
        {
            InitializeComponent();
        }

        public override void trueNextVisible()
        {
            this.btn_next.Visible = true;
        }

        public override void falsePassVisible()
        {
            //base.falsePassVisible();
            this.btn_pass.Visible = false;
        }

        public override void falseNextVisible()
        {
            // base.falseNextVisible();

            this.btn_next.Visible = false;
        }

        public override void truePassVisible()
        {
            //base.truePassVisible();

            this.btn_pass.Visible = true;
        }

        //定石タイプを変数にもたせる
        string josekiType = "";
        //ウサギ配列
        //int[,] usagiArray = new int[11,11];
        int[,] usagiArray = 
        {   { 5, 4 },
            { 3, 5 }, 
            { 2, 4 }, 
            { 5, 3 }, 
            { 4, 2 }, 
            { 2, 5 }, 
            { 3, 2 }, 
            { 5, 5 },
            { 4, 5 },
            { 3, 6 }
        };

        //牛はいれつ
        int[,] usiArray =
        {
            { 5,4 },
            { 5,5 },
            { 4,5 },
            { 5,3 },
            { 4,2 },
            { 2,4 },
            { 2,3 },
            { 4,6 },
            { 2,5 }
        };

        //鼠配列
        int[,] nezumiArray =
        {
            { 5,4 },
            { 5,3 },
            { 4,2 },
            { 5,5 },
            { 3,2 }
        };

        //実際においてひっくり返す。
        //ひっくり返せる駒がないならFalseを返す。
        public  bool putKikai(int bannti)
        {
            //もしひっくり返せるなら
            if (howManyReturn(bannti) != 0)
            {
                //機会がおく。
                mainCLASS.boardIdentitiy[bannti] = mainCLASS.kikaicolor;
                //ひっくり返す
                AI.allDirReturn(bannti);
                return true;
            }
            else
            {
                return false;
            }
        }
         
        //ここでどこに打つか決める
        private void joukyuBoard_kikai_Load(object sender, EventArgs e)
        {
            this.btn_next.Visible = true;
           
            if (mainCLASS.onlyShowFlag == false)
            {
                if (putCorner() == -1)
                {
                    int blank = mainCLASS.countBlank();
                    int maxBlank = mainCLASS.x_size * mainCLASS.y_size - 4;
                    int i = maxBlank - blank;

                    //i=0のときは、なんでもOK
                    //もし人が後攻を選んだら初めは機械。
                    //初めは5,4が無難らしい。
                    if(i == 0)
                    {
                        putKikai(AI.coordinateBannti(5, 4));
                    }
                    //i=1のとき、おけるタイプを選ぶ（ウサギORウシ）
                    if(i == 1)
                    {
                        int usagi1 = AI.coordinateBannti(usagiArray[i, 0], usagiArray[i, 1]);
                        int usi1 = AI.coordinateBannti(usiArray[i, 0], usiArray[i, 1]);
                        int nezu1 = AI.coordinateBannti(nezumiArray[1, 0], nezumiArray[i, 1]);
                        if( howManyReturn(usagi1) != 0){
                            josekiType = "usagi";
                            putKikai(usagi1);
                        }else if(howManyReturn(usi1) != 0)
                        {
                            josekiType = "usi";
                            putKikai(usi1);
                        }else if(howManyReturn(nezu1) != 0)
                        {
                            josekiType = "nezu";
                            putKikai(nezu1);
                        }
                    }else  if (1<i && i < 11)
                    {

                        if (josekiType == "usagi")
                        {
                            //usagi
                            putJouseki(AI.coordinateBannti(usagiArray[i - 1, 0], usagiArray[i - 1, 1]), AI.coordinateBannti(usagiArray[i, 0], usagiArray[i, 1]));

                        }
                        else if (josekiType == "usi")
                        {
                            //usagi
                            putJouseki(AI.coordinateBannti(usiArray[i - 1, 0], usiArray[i - 1, 1]), AI.coordinateBannti(usiArray[i, 0], usiArray[i, 1]));

                        }

                    }




                    this.Close();
                }
                else
                {
                    //4角におく。
                    putKikai(putCorner());
                    this.Close();
                }
            }


            //AI.coordinateBannti(4, 5)


        }

        //今が1つ前に人が打つべきだった番地、これから機械がおくべき番地、何手目を入れて、
        //おくべき打番号時に人が打った番地が正しければ、おく。
        //人、機械合わせて何手目　=　i
        //i番手目に人があるところにおいていればおく
        private void putJouseki(int lasthuman,int kikaiNext)
        {
            if(mainCLASS.lastHumanBannti == lasthuman)
            {
                putKikai(kikaiNext);
            }
        }


        public override void click_event(int i)
        {
           // base.click_event(i);
        }


     
    }
}

