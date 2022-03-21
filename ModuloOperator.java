import java.util.*;

public class ModuloOperator {

	public static void main(String[] args) {
		
		Scanner scan  = new Scanner(System.in);
		int first;
		int second;
		int answer;
		
		
		first = getFirst();
		second = getSecond();
		time();
		answer = getAnswer(first, second);
		
		System.out.println("The nearest multiple of " + first + " from " + second + " is " + answer + "!");
		
		
		
	
	}
	
	//Thread Sleep funtion for calculating
	public static void time()
	{
	
		
		try {
			
		System.out.println("Calculating...");
		Thread.sleep(1500);
		
		}
		catch(Exception e)
		{
			
			
		}
		
	}
	
	//Method that receives the first number from the user
	public static int getFirst()
	{
		Scanner scan = new Scanner(System.in);
		int first;
		
		System.out.println("Enter a number you want to find a multiple of: ");
		first = scan.nextInt();
		
		return first;
	}
	
	//Method that receives the second number from the user
	public static int getSecond()
	{
		Scanner scan = new Scanner(System.in);
		int second;
		
		System.out.println("Enter a second number: ");
		second = scan.nextInt();
		
		return second;
	}
	
	//Method that calculates the answer
	public static int getAnswer(int first, int second)
	{
		int answer = 0;
		int leftOver = 0;
		
		if(second%first == 0)
		{
			return second;
			
		}
		else 
		{
		 leftOver = second%first;
		 answer = second - leftOver;
		
			
		}
		
		return answer;
	}
		}
	


