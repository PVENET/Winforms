namespace Crud_Cervezas;

public partial class Form2 : Form
{
    private TableLayoutPanel tlCampos;
    private Label lblNombre;
    private Label lblEstilo;
    private Label lblAlcohol;
    private TextBox txtNombre;
    private TextBox txtEstilo;
    private TextBox txtAlcohol;
    private Button btnGuardar;
    private Button btnCancelar;
    public Cerveza nuevaCerveza;
    public Form2()
    {
        tlCampos = new TableLayoutPanel();
        lblNombre = new Label();
        lblEstilo = new Label();
        lblAlcohol = new Label();
        txtNombre = new TextBox();
        txtEstilo = new TextBox();
        txtAlcohol = new TextBox();
        btnGuardar = new Button();
        btnCancelar = new Button();
        nuevaCerveza= new Cerveza();
        InitializeComponent();
        InicializarComponentes();
    }
    public Form2(Cerveza cerveza):this(){
        nuevaCerveza=cerveza;
        txtNombre.Text=cerveza.Nombre;
        txtEstilo.Text=cerveza.Estilo;
        txtAlcohol.Text=cerveza.Alcohol.ToString();
    }

    private void InicializarComponentes()
    {
        this.Size=new Size(300,300);
        lblNombre.AutoSize=true;
        lblEstilo.AutoSize=true;
        lblAlcohol.AutoSize=true;
        lblNombre.Text="Nombre";
        lblEstilo.Text="Estilo";
        lblAlcohol.Text="Alcohol";
        txtNombre.Size = new Size(150,23);
        txtEstilo.Size = new Size(150,23);
        txtAlcohol.Size = new Size(100,23);
        btnGuardar.AutoSize= true;
        btnCancelar.AutoSize= true;
        btnGuardar.Location = new Point(15,200);
        btnCancelar.Location= new Point(200,200);
        btnGuardar.Text="Guardar";
        btnCancelar.Text="Cancelar";
        tlCampos.ColumnCount=1;
        tlCampos.RowCount=6;
        tlCampos.AutoSize=true;
        tlCampos.Controls.Add(lblNombre);
        tlCampos.Controls.Add(txtNombre);
        tlCampos.Controls.Add(lblEstilo);
        tlCampos.Controls.Add(txtEstilo);
        tlCampos.Controls.Add(lblAlcohol);
        tlCampos.Controls.Add(txtAlcohol);
        tlCampos.Location= new Point(15,15);

        btnCancelar.Click+=new EventHandler(btnCancelar_Click);
        btnGuardar.Click+=new EventHandler(btnGuardar_Click);

        this.Controls.Add(tlCampos);
        this.Controls.Add(btnGuardar);
        this.Controls.Add(btnCancelar);
    }
    private void btnCancelar_Click(object? sender, EventArgs e){
        this.DialogResult=DialogResult.Cancel;
        this.Close();
    }
    private void btnGuardar_Click(object? sender, EventArgs e){
        nuevaCerveza.Nombre=txtNombre.Text;
        nuevaCerveza.Estilo=txtEstilo.Text;
        nuevaCerveza.Alcohol=Double.Parse(txtAlcohol.Text);
        this.DialogResult=DialogResult.OK;
        this.Close();
    }
}
