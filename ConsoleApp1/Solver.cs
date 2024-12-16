namespace VersionChecker
{
    public class Solver
    {

        static HashSet<string> versions = new HashSet<string>();

        public IEnumerable<string> FindDistinctVersions(Device rootDevice, Func<Device, string> func)
        {

            GetVersions(rootDevice, func);

            return versions.ToList();
        }

        private void GetVersions(Device rootDevice, Func<Device, string> func)
        {

            versions.Add(func(rootDevice)); 

            foreach (var d in rootDevice.Children)
            {
                {
                    FindDistinctVersions(d, func);
                }
            }
        }
    }
}
