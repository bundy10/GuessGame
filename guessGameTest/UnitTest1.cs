
namespace guessGameTest;

public class UnitTest1
{
    private const string Expected = "Number Guessing Game";
    [Fact]
    public void startMessageTest()
    {
        using (var sw = new StringWriter())
        {

            Console.SetOut(sw);
            guessGame.Dialog.StartMessage();

            var result = sw.ToString().Trim();
            Assert.Equal(Expected, result);
        }
    }


}
