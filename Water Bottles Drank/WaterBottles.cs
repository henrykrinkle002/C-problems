public void WaterBottles{
	public int NumWaterBottles(int numBottles, int numExchange){
	int total = numBottles;
	int empties = numBottles;

	while(empties >= numExchange){
		int newBottles = empties/numExchange;
		total += newBottles;
		int remainder = empties % numExchange;
		empties = newBottles + empties;
	}
	return total;
	// or use equation ((numBottles * numExchange) - 1)/numExchange - 1 ;
	}
}