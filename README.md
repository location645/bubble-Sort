# bubble-Sort
アルゴリズムの学習　および　アルゴリズムの落としこみのため記述。

学習できた内容
・ConsoleWrite ConsoleWriteLine の差異
・配列の個数を取得し、その応用。
int[] nums =　｛｝  int[] nums = { 323, 33, 46, 552, 664, 443, 44, 332, 332
 Console.WriteLine(nums.Length);
 ・数値入れ替えの処理
                         tmp = nums[end - 1];
                        nums[end - 1] = nums[end];
                        nums[end] = tmp;
・バブルソートに従った条件
バブルソートは基準の数値（今回は昇順）より小さいものを左に移動させる。
                    if (nums[end - 1] > nums[end])
