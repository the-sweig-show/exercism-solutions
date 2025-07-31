public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
       if (phoneNumber.Length != 12 || phoneNumber[3] != '-' || phoneNumber[7] != '-')
       {
           throw new ArgumentException("Phone number must be in the format NNN-NNN-NNNN");
       }

        string areaCode = phoneNumber.Substring(0,3);
        string prefix = phoneNumber.Substring(4,3);
        string localNumber = phoneNumber.Substring(8);

        bool isNewYork = areaCode == "212";
        bool isFake = prefix == "555";
        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
