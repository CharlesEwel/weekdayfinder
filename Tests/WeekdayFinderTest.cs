using Xunit;
namespace WeekdayFinder.Objects
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void FindWeekday_Date_Weekday()
    {
      Timeline newTimeLine = new Timeline ();
      Assert.Equal("Humpday", newTimeLine.FindWeekday(5,9,1990));
    }
  }
}
