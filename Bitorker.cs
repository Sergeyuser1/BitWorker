using Sysyem;

public static class BitWorker
{
    public static
         private string searchIPinFileName(string fileName)
    {
        nameIP = string.Empty;
        Regex reg = new Regex(@"[0-9]{0,3}_[0-9]{0,3}_[0-9]{0,3}_[0-9]{0,3}-_{1,10}\d{1,3}_\d{1,3}_\d{1,3}_\d{1,3}");//
        Match match = reg.Match(fileName);
        nameIP = match.Value;
        nameIP = nameIP.Replace("-_", "-");
        nameIP = nameIP.Replace("-__", "-");
        nameIP = nameIP.Replace("-___", "-");
        nameIP = nameIP.Replace("-____", "-");
        nameIP = nameIP.Replace('_', '.');
        nameIP = nameIP.Replace("-.", "-");

        return nameIP;
    }
    public int LenFile(int position) //вычисление длины передваваемого файла
    {
        int len = 0;
        byte[] bytelenfile = new byte[8];//здесь хранится длина файла в байтовом представлении
        for (int i = 0; i < 8; i++)
        {
            bytelenfile[i] = byteFile[position + i];
        }
        for (int i = 0; i < 8; i++)
        {
            len += (int)Math.Pow(256, i) * bytelenfile[i];
        }
        if (len < 0)
        {
            len = 0;
        }
        countFile++;
        return len;
    }
}

