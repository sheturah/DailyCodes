import java.util.Scanner;
import java.math.*;

public class UnusalShapes {

	public static void main(String[] args) {
		
		double pentaLength;
		double hexaLength;
		
		double pentaPerimeter;
		double hexaPerimeter;
		
		double pentaArea;
		double hexaArea;
	
		
		//calculates and prints the Pentagon measurement
		System.out.println("[Pentagon Calculator]");
		pentaLength = getLength();
		pentaPerimeter = PrintPerimeter(5, pentaLength);
		pentaArea = PentaArea(pentaLength);

		//calculates and prints the Hexagon measurement
		System.out.println("\n[Hexagon Calculator]");
		hexaLength = getLength();
		hexaPerimeter = PrintPerimeter(6, hexaLength);
		hexaArea = HexaArea(hexaLength);
	}
	
	//Method returns the length of the shape via user input
	public static double getLength()
	{
		Scanner scan = new Scanner(System.in);
		double length;
		
		System.out.println("Enter the length of one side: ");
		length = scan.nextDouble();
		
		
		return length;
	}
	
	//Calculates, print, and returns the parameter
	public static double PrintPerimeter(int sides, double length)
	{
		
		double perimeter;
		perimeter = sides * length;
		int numb = (int)perimeter;
		
		
		if(sides == 5)
		{
		System.out.println("Pentagon Perimeter = " + numb);
		}
		else 
		{
			System.out.println("Hexagon Perimeter = " + numb);
			
		}
		return numb;
		
	}
	
	//Finds the area for a Pentagon
	public static double PentaArea(double length)
	{
		double area = (Math.sqrt(5*(5 + 2 * Math.sqrt(5))) * length * length)/ 4;
		
		area = Round(area);
		System.out.println("Pentagon Area: " + area);
		return area;
	}
	
	//Finds the area for a Hexagon
	public static double HexaArea(double length)
	{
		double area = (6*(length*length))/(4*Math.tan(Math.PI/6));
		
		area = Round(area);
		System.out.println("Hexagon Area: " + area);
		return area;
	}
	
	//Rounds two decimal spaces
	public static double Round(double number)
	{
		
		number = Math.round(number * 100)/100.0;
		return number;
	}
	

}
