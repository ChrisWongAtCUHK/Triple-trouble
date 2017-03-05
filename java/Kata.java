public class Kata {
	public static int TripleDouble(long num1, long num2) {
		String s1 = String.valueOf(num1).replaceFirst(
				".*(000|111|222|333|444|555|666|777|888|999).*", "$1");
		return s1.length() == 3
				&& String.valueOf(num2).contains(s1.substring(0, 2)) ? 1 : 0;
	}
}