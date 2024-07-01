using System;
					
public class MultiplyArrayElements
{
	static int[] MultiplyArrayElementsExceptSelf (int[] nums) {
		int length = nums.Length;
        int mult = 1;
		int[] retNumers = new int[length];
        for (int j=0;j<length; j++) {
            mult *= nums[j];
        }
		for (int i=0; i< length; i++) {
			retNumers[i] = mult / nums[i];
		}
		return retNumers;
	}
	public static void Main()
	{
		int[] numbers = [2,4,5,7,8];
		int[] result = MultiplyArrayElementsExceptSelf(numbers);
		Console.WriteLine("orig: " + string.Join(',', numbers));
		Console.WriteLine("orig: " + string.Join(',', result));
	}
}