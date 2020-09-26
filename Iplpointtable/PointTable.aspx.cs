using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PointTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string baseApiurl = "https://demo7531234.mockable.io/";

        System.Net.WebClient client = new System.Net.WebClient();
        client.Headers.Add("content-type", "application/json");
        client.Encoding = Encoding.UTF8;
        string result = client.DownloadString(baseApiurl + "iplpointtable");
        PointTableResponse pointTableResponse = ((new JavaScriptSerializer()).Deserialize<PointTableResponse>(result));
        this.point_list.DataSource = pointTableResponse.result;
        this.point_list.DataBind();
    }

    public class PointTableResponse
    {
        public List<Team> result { get; set; }
    }
    public class Team
    {
        public string team_name{ get; set; }
        public string Played{ get; set; }
        public string Won{ get; set; }
        public string Lost{ get; set; }
    }
}