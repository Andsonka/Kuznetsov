using System.Text.RegularExpressions;

namespace TestProject1.Tests
{
    public class UnitTest1
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsValidGroupName()
        {
            return Regex.Match(GroupName, @"/\D*-\d*-\d\d/g").Success;
        }
    }
}