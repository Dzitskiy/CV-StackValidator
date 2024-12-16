namespace VersionChecker
{
    public class Device
    {

        public Device(string version, List<Device> children)
        {
            Version = version;
            Children = children;

        }
        public string Version { get; }
        public string Admin { get; }

        public List<Device> Children { get; }
    }
}
