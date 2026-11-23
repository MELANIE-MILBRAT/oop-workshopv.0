class Images : Media
{
    private int resolution;
    private string fileFormat;
    private int fileSize;
    private string dataTaken;

    public Images(string title, int resolution, string creator, string fileFormat, int fileSize, string dataTaken) :base(title, creator)

    {
        this.resolution = resolution;
        this.fileFormat = fileFormat;
        this.fileSize = fileSize;
        this.dataTaken = dataTaken;
    }
}