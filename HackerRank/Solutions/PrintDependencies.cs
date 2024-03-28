using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Solutions
{
    public class PrintDependencies
    {
        /*
svg@1.0 -> highcharts@7.0 -> @fluentui/react@9.112
export const dependencies: string[] = [
    "@fluentui/react@9.112",
    "    -axios@2.2",
    "    -highcharts@7.0",
    "    -lodash@1.12",
    "    -react@18.0",
    "",
    "axios@2.15",
    "    -lodash@1.3",
    "",
    "axios@2.2",
    "    -lodash@0.90",
    "",
    "svg@1.0",
    "    -@fluentui/react@9.112",
    "    -lodash@1.12",
    "",
    "highcharts@7.0",
    "    -Babel@6.0",
    "    -lodash@1.12",
    "    -svg@1.0",
    "",
    "react@17.1",
    "    -Babel@5.9",
    "",
    "react@18.0",
    "    -Babel@6.0",
    "",
    "Babel@5.9",
    "Babel@6.0",
    "lodash@0.90",
    "lodash@1.12",
    "lodash@1.3"
];
*/


        public void ExecuteWithRemovingCurrentRecord()
        {
            var result = new List<string>();
            var map = new Dictionary<string, HashSet<string>>();
            map.Add("react@18.0", new HashSet<string>() { "Babel@6.0" });
            map.Add("svg@1.0", new HashSet<string>() { "lodash@1.12" });
            map.Add("highchart@7.0", new HashSet<string>() { "svg@1.0", "babel@6.0" });
            map.Add("fluentui/react@9.112", new HashSet<string>() { "axios@2.2", "highchart@7.0" });
            PrintDependentPackagesWithRemovingCurrentRecord("lodash", "1.12", map, result);

            Console.WriteLine(string.Join(",", result));
        }

        public void ExecuteWithoutRemovingCurrentRecord()
        {
            var result = new List<string>();

            var map = new Dictionary<string, HashSet<string>>();
            map.Add("react@18.0", new HashSet<string>() { "Babel@6.0" });
            map.Add("svg@1.0", new HashSet<string>() { "lodash@1.12" });
            map.Add("highchart@7.0", new HashSet<string>() { "svg@1.0", "babel@6.0" });
            map.Add("fluentui/react@9.112", new HashSet<string>() { "axios@2.2", "highchart@7.0" });
            PrintDependentPackagesWithoutRemovingCurrentRecord("lodash", "1.12", map, result);
            Console.WriteLine(string.Join(",", result));
        }

        public void PrintDependentPackagesWithRemovingCurrentRecord(string packageName, string version, Dictionary<string, HashSet<string>> map, List<string> result)
        {
            if (map.Keys.Count == 0) return;

            var pkg = string.Concat(packageName, "@", version);

            var item = map.ElementAt(0);
            var pkgName = packageName;
            var pkgVersion = version;

            if (item.Value.Contains(pkg))
            {
                result.Add(item.Key);
                var depWithVersion = item.Key.Split('@');
                if (depWithVersion.Length == 2)
                {
                    pkgName = depWithVersion[0];
                    pkgVersion = depWithVersion[1];
                }
                else if (depWithVersion.Length == 3)
                {
                    pkgName = depWithVersion[0] + depWithVersion[1];
                    pkgVersion = depWithVersion[2];
                }
            }
            
            map.Remove(item.Key);
            PrintDependentPackagesWithRemovingCurrentRecord(pkgName, pkgVersion, map, result);
        }

        public void PrintDependentPackagesWithoutRemovingCurrentRecord(string packageName, string version, Dictionary<string, HashSet<string>> map, List<string> result)
        {
            var pkg = string.Concat(packageName, "@", version);
            foreach (var item in map)
            {
                if (item.Value.Contains(pkg))
                {
                    result.Add(item.Key);
                    var depWithVersion = item.Key.Split('@');
                    var pkgName = string.Empty;
                    var pkgVersion = string.Empty;
                    if (depWithVersion.Length == 2)
                    {
                        pkgName = depWithVersion[0];
                        pkgVersion = depWithVersion[1];
                    }
                    else if (depWithVersion.Length == 3)
                    {
                        pkgName = depWithVersion[0] + depWithVersion[1];
                        pkgVersion = depWithVersion[2];
                    }

                    PrintDependentPackagesWithoutRemovingCurrentRecord(pkgName, pkgVersion, map, result);
                }
            }
        }

    }
}
