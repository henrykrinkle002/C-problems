public class Solution{
	public int Trap(int[] height){
		int left=0, right=height.Length -1, leftmax=0, rightmax=0, water=0;

		while(left < right){
			if(height[left] < height[right]){ 
				if(leftmax > height[left])
					leftmax = height[left];
				else
					water += leftmax - height[left];
			left++;
			}
			else{
				if(height[right] > rightmax) rightmax = height[right];
				else
				water += rightmax - height[right];
			right--;
			}

		}
		return water;
	}
}