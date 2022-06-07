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
        int arraySize = 0;
        bool fillJosekiFlag = false;


        //ウサギ配列
        //int[,] usagiArray = new int[11,11];
        int[,] usagiArray = 
        {   { 5, 4 }, //37
            { 3, 5 }, //43
            { 2, 4 }, //34
            { 5, 3 }, //27
            { 4, 2 }, //20
            { 2, 5 }, //42
            { 3, 2 }, //11
            { 5, 5 }, //45
            { 4, 5 }, //29
            { 3, 6 }  //51
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
        //ひっくり返せる駒がないならひっくり返さない
        public  void putKikai(int bannti)
        {
            //もしひっくり返せるなら
            if (howManyReturn(bannti) != 0)
            {
                //機会がおく。
                mainCLASS.boardIdentitiy[bannti] = mainCLASS.kikaicolor;
                //ひっくり返す
                AI.allDirReturn(bannti);
                //return true;
            }
            //else
            //{
            //    //return false;
            //}
        }
         

        public bool canPutOrNot(int bannti)
        {
            //もしひっくり返せるなら
            if (howManyReturn(bannti) != 0)
            {
                ////機会がおく。
                //mainCLASS.boardIdentitiy[bannti] = mainCLASS.kikaicolor;
                ////ひっくり返す
                //AI.allDirReturn(bannti);
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
                    else if (i == 1)
                    {
                        //newLogic!!
                        if (mainCLASS.lastHumanBannti == 43)
                        {
                            josekiType = "usagi";
                            arraySize = 10;
                            putFromFront(usagiArray, arraySize);
                        }
                        else if (mainCLASS.lastHumanBannti == 29)
                        {
                            josekiType = "nezu";
                            arraySize = 5;
                            putFromFront(nezumiArray, arraySize);
                        }
                        else if (mainCLASS.lastHumanBannti == 20)
                        {
                            josekiType = "usi";
                            arraySize = 9;
                            putFromFront(usiArray, arraySize);
                        }
                        else if (mainCLASS.lastHumanBannti == 34)
                        {
                            josekiType = "usagi";
                            arraySize = 10;
                            putFromFront(usagiArray, arraySize);
                        }

                    }
                    else
                    {
                        
                        if(!fillJosekiFlag)
                        {
                            switch (josekiType)
                            {
                                case "usagi":
                                    fillJosekiFlag = putFromFront(usagiArray, arraySize);
                                    break;
                                case "nezu":
                                    fillJosekiFlag = putFromFront(nezumiArray, arraySize);
                                    break;
                                case "usi":
                                    fillJosekiFlag = putFromFront(usiArray, arraySize);
                                    break;

                            }
                        }
                        //うえのパターンだけど打てなくてFilljosekiFlagが変わるかもだから、もう一度条件
                        //定石が終わったら、中級モードと同じ。
                        if (fillJosekiFlag)
                        {
                            AI.allDirReturn(AI.saveKikaiBannti(mainCLASS.kikaicolor));
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






        //お試しロジック
        //前から空いてる配列があればおく。
        //定石全部埋まってるか調べられる。埋まってたらtrue
        public  bool putFromFront(int[,] array,int arraySize)
        {
            bool returnFlag = false;
            for (int i = 0; i<= arraySize; i++)
            {
                if(i == arraySize)
                {
                    returnFlag = true;
                }
                else
                {
                    //空かつひっくり返せたらおく。
                    int candidateBannti = AI.coordinateBannti(array[i, 0], array[i, 1]);
                    //からかつひっくり返せたら置く。
                    if (mainCLASS.boardIdentitiy[candidateBannti] == " " && canPutOrNot(candidateBannti))
                    {
                        //おけたらぬける
                        putKikai(candidateBannti);
                        break;
                    }
                }
                

            }

            return returnFlag;

        }



    }


}

