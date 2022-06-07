using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oseroGame
{
    class AI
    {
        public static void main()
        {
            //mainCLASS.boardIdentitiy
           
        }
		
		public static string chengeColor(string now_color)
        {
			if(now_color == "SHIRO")
            {
				return "KURO";
            }
            else
            {
				return "SHIRO";
            }
        }

		public static int [] searchNextKikaiBannti()
        {
			int countReturnNumber = 0;
			int []arrayPoint = new int[64]; 
			for(int i = 0; i <= 63; i++)
            {
				countReturnNumber = 0;
				if (mainCLASS.boardIdentitiy[i]==" ")
                {
					for (int x = -1; x <= 1; x++)
					{
						for (int y = -1; y <= 1; y++)
						{
							if (x == 0 && y == 0) { 
							 }
							else
							{
								countReturnNumber += countStoneReturn(x, y, i);
							}
						}

					}
				
                }
                else
                {
					countReturnNumber = 0;
                }
				arrayPoint[i] = countReturnNumber;
            }


			return arrayPoint;
        }

		//次に機械がおくばんちを返す。
		//そして決まったそのばんちをおく。（boardidentitiyにいれる。）
		public static int saveKikaiBannti(string color)
        {
			int blankCount = mainCLASS.countBlank();
			int[] saveCount = searchNextKikaiBannti();
			int nextKikaiBannti = 0;
			//要修正
			//6割埋まっていない場合
			if (Convert.ToDouble(blankCount) >= (mainCLASS.x_size * mainCLASS.y_size * 0.4))
			{
				//1番少なくひっくり返せる場所が０の場合
                if (saveCount.Min()　== 0)
                {
					//ひっくり返せる数=iとしてる
					//ひっくり返せる最大の数は32
					for (int i = 1; i < mainCLASS.x_size * 4; i++)
                    {
                        int candidata = Array.IndexOf(saveCount, i);
						//もしひっくり返せる場所がi個の場所があれば
                        if (candidata != -1)
                        {
							
                            nextKikaiBannti = candidata;
                            //mainCLASS.boardIdentitiy[nextKikaiBannti] = color;
                            break;
                        }

                        if (i == mainCLASS.x_size * 4)
                        {
							//ダイアログだけ出してなにもしない
							MessageBox.Show("今回ははひっくり返せる場所がないので置きません。", "", MessageBoxButtons.OK);
						}
					}                   
                }
                else
                {
					//一番少なくひっくり返せる場所に置く。
					nextKikaiBannti = Array.IndexOf(saveCount, saveCount.Min());
				}

			}
			else
			{				
				nextKikaiBannti = Array.IndexOf(saveCount, saveCount.Max());
			}
			//実際に置く。
			mainCLASS.boardIdentitiy[nextKikaiBannti] = color;
			return nextKikaiBannti;
		}

		//①何個ひっくり返せるか調べる関数と、②出発地点から方向（引数）に①こひっくり返す
		public static int countStoneReturn(int dirX, int dirY,int bannti)
		{
			string color = mainCLASS.now_PLAYER == mainCLASS.human ? mainCLASS.humancolor : mainCLASS.kikaicolor;
			string notNowColor = color == "SHIRO" ? "KURO" : "SHIRO";
			//調べる座標
			
			bool flagNotReturn = true;
			int count = 0;
			int x = getX(bannti);
			int y = getY(bannti) ;
			//int bannti = mainCLASS.bannti ;
			int i = 0;
			for (i = 0; i < 7; i++)
			{
				x = x + dirX;
				y = y + dirY;
				if (x < 0 || 7 < x) { break; }
				if (y < 0 || 7 < y) { break; }
				//if (0 <= x && x <= 7&&0<=y&&y<=7) {

				bannti = coordinateBannti(x, y);

				if (mainCLASS.boardIdentitiy[bannti] ==notNowColor)
				{
					count++;
                }
			
				if (mainCLASS.boardIdentitiy[bannti] == color)
				{
					flagNotReturn = false;
					break;
				}
				if(mainCLASS.boardIdentitiy[bannti] ==" ")
                {
					break;
                }
                 

			}
            //if (count == i) { flagNotReturn = true; }

            if (flagNotReturn == true) { count = 0; }
			return count;
		}

		//ひっくり返すだけの関数
		public static void onlyReturn(int dirX,int dirY,int returnCount,int chekbannti)
        {
			string color = mainCLASS.now_PLAYER == mainCLASS.human ? mainCLASS.humancolor : mainCLASS.kikaicolor;
			int bannti = chekbannti ;
			//banntiから、X,Yを求める
			int x = getX(chekbannti);
			int y = getY(chekbannti);
			for (int count = 0;count<returnCount ; count++ )
            {
				x = x + dirX;
				y = y + dirY;
				if (x < 0 || 7 < x) { break; }
				if (y < 0 || 7 < y) { break; }
				bannti = coordinateBannti(x, y);
				mainCLASS.boardIdentitiy[bannti] = color;
				
			}
        }



		public static void checkBetween(int bannti)
		{
			
			allDirReturn(bannti);

		}
		public static void allDirReturn(int bannti)
        {
			
            for (int x=-1; x <= 1 ; x++) {
				for(int y = -1; y <= 1; y++) {
					if (x == 0 && y == 0) { }
					else
					{
						onlyReturn(x, y, countStoneReturn(x, y, bannti),bannti);
					}
				}
				
			}
			
        }

			



		

		//banntiからX,Yを吐き出す。
		public static int getX(int bannti)
        {
			//bannti += 1;
			int size = mainCLASS.x_size  ;
			int x = 0;
			int y = 0;
				for(int i = 0; i < 8; i++)
                {
					
                    if (0 <= bannti && bannti <= 7)
                    {
						x = bannti ;
						y = i;
						break;
                    }
				bannti -= size;
			}
				
			return x;
        }

		public static int getY(int bannti )
        {
			//bannti += 1;
			int size = mainCLASS.x_size;
			int x = 0;
			int y = 0;
		
			for (int i = 0; i < 8; i++)
			{
				
				if (0 <= bannti && bannti <= 7)
				{
					x = bannti ;
					y = i;
					break;
				}
				bannti -= size;
			}
			return y;

		}

		//x,yからばんちを吐き出す
		public static int coordinateBannti(int x, int y)
		{
			int bannti = x + y*(mainCLASS.y_size);
			return bannti;
		}

	}
}
