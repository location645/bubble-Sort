using System;

class Bubble
{
    static void Main()
    {
        int[] nums = { 323, 33, 46, 552, 664, 443, 44, 332, 332 };
            int start,end,tmp;　//指定変数複数。　int , , , ;

            Console.WriteLine(nums.Length);

            Console.Write("元の配列");


        //for 処理　１回目
        //変数に入力された配列を表示する
            for (int i = 0; i < nums.Length; i++) //文字数分の処理？」
            {
                Console.Write(" " + nums[i]); 
                //for外側の処理で取得したiの数字をnumの変数に割り当てる
            }
            Console.WriteLine();  //writelineとは？


        //for 処理　2回目
        //ソートはここから

            for (start = 1; start < nums.Length; start++)
            {

                for (end = nums.Length - 1; end >= start; end--)
                {
                    if (nums[end - 1] > nums[end])
                    {
                        tmp = nums[end - 1];
                        nums[end - 1] = nums[end];
                        nums[end] = tmp;
                    
                    }
                
                }
            
            
            }

            Console.Write("ソート後の配列:");
            for (int i = 0; i < nums.Length; i++)
            {

                Console.Write(" " + nums[i]);
            }

            Console.WriteLine();    
    }

}
