namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        cmbCalculo.SelectedItem = "Périmetro";
        cmbFiguras.SelectedItem = "Cuadrado";
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 350);
        //Etiqueta "Figura"
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);
        //Combobox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);
        //Etiqueta "Cálculo"
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);
        //Combobox Cálculos
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Périmetro");
        cmbCalculo.Items.Add("Área");
        cmbCalculo.Location = new Point(150, 40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);
        //Etiqueta "Altura"
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10, 80);
        lblAltura.Visible=false;
        //TextBox Altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100, 20);
        txtAltura.Location = new Point(60, 75);
        txtAltura.Visible=false;
        //Etiqueta "Base"
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10, 120);
        lblBase.Visible=false;
        //TextBox Base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 20);
        txtBase.Location = new Point(60, 115);
        txtBase.Visible=false;
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);
        //Etiqueta "Resultado"
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);
        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(70, 275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);

    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculo.SelectedIndex.ToString();
        int altura=0;
        if(txtAltura.Text!=""){
            altura=Convert.ToInt32(txtAltura.Text);
            txtResultado.Text=(altura*4).ToString();
        }
    }
    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
        }

    }
    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
        }
    }
}
