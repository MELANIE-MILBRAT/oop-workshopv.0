class Apps : Media
{
    private string version;
    private string filesize;
    private string supportedPlatforms;

    public Apps(string title, string version, string creator, string supportedPlatforms, string filesize) :base(title, creator)

    {
        this.version = version;
        this.supportedPlatforms = supportedPlatforms;
        this.filesize = filesize;
    }
}