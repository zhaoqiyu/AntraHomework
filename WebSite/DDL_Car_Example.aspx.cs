using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Make
{
    public int Id { get; set; }
    public string make { get; set; }
}

public class Model
{
    public int makeId { get; set; }
    public int Id { get; set; }
    public string model { get; set; }
}
public class Color
{
    public int Id { get; set; }
    public string color { get; set; }
}

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            BindMake();
        }
    }

   
    
    private void BindMake() {
        List<Make> lst = new List<Make>();
        lst.Add(new Make() { Id = 1, make = "Chevrolet" });
        lst.Add(new Make() { Id = 2, make = "Ford" });
        lst.Add(new Make() { Id = 3, make = "Jeep" });

        ddlCarMake.DataSource = lst;
        ddlCarMake.DataTextField = "make";
        ddlCarMake.DataValueField = "Id";
        ddlCarMake.DataBind();

        ddlCarMake.Items.Insert(0, new ListItem() { Text = "--Select--", Value = "0" });
    }

    private void BindModel(int makeid ) {
        List<Model> lst = new List<Model>();
        lst.Add(new Model() { makeId = 1, Id = 1, model = "Impala" });
        lst.Add(new Model() { makeId = 1, Id = 2, model = "Equinox" });
        lst.Add(new Model() { makeId = 1, Id = 3, model = "Colorado" });

        lst.Add(new Model() { makeId = 2, Id = 4, model = "Focus" });
        lst.Add(new Model() { makeId = 2, Id = 5, model = "Fusion" });
        lst.Add(new Model() { makeId = 2, Id = 6, model = "Mustang" });

        lst.Add(new Model() { makeId = 3, Id = 7, model = "Cherokee" });
        lst.Add(new Model() { makeId = 3, Id = 8, model = "Wrangler" });
        lst.Add(new Model() { makeId = 3, Id = 9, model = "Compass" });


        ddlCarModel.DataSource = lst.FindAll(
            delegate(Model model) {
                return model.makeId == makeid;
            }
        );
        ddlCarModel.DataTextField = "model";
        ddlCarModel.DataValueField = "Id";
        ddlCarModel.DataBind();

        ddlCarModel.Items.Insert(0, new ListItem() { Text = "--Select--", Value = "0" });
    }

    private void BindColor() {
        List<Color> lst = new List<Color>();
        lst.Add(new Color() { Id = 1, color = "Black" });
        lst.Add(new Color() { Id = 2, color = "White" });
        lst.Add(new Color() { Id = 3, color = "Sliver" });
        lst.Add(new Color() { Id = 4, color = "Red" });
        ddlCarColor.DataSource = lst;
        ddlCarColor.DataTextField = "color";
        ddlCarColor.DataValueField = "Id";
        ddlCarColor.DataBind();

        ddlCarColor.Items.Insert(0, new ListItem() {Text = "--Select--", Value = "0" });
        
        
    }

    protected void ddlCarMake_SelectedIndexChanged(object sender, EventArgs e) {
        BindModel(ddlCarMake.SelectedIndex);
    }

    protected void ddlCarModel_SelectedIndexChanged(object sender, EventArgs e) {
            BindColor();
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e) {
        string result;
        if (ddlCarColor.SelectedIndex == 0 || ddlCarMake.SelectedIndex == 0 || ddlCarModel.SelectedIndex == 0) {
            labResult.Text = "Plese select all selection before you submit.";
        } else {
            result = "Your Choise is " + ddlCarColor.SelectedItem + " " + ddlCarMake.SelectedItem + " " + ddlCarModel.SelectedItem;
            labResult.Text = result;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e) {
        ddlCarColor.ClearSelection();
        ddlCarMake.ClearSelection();
        ddlCarModel.ClearSelection();
        labResult.Text = "Please make your choics.";
    }

}
