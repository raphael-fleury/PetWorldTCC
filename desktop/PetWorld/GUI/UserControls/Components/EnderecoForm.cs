using System;
using System.Windows.Forms;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class EnderecoForm : UserControl
    {
        #region Events
        private Action fieldsChanged;

        public event Action FieldsChanged
        {
            add { fieldsChanged += value; }
            remove { fieldsChanged -= value; }
        }
        #endregion

        public EnderecoForm()
        {
            InitializeComponent();
            txtLogradouro.TextChanged += (x, y) => fieldsChanged?.Invoke();
            txtNumEndereco.TextChanged += (x, y) => fieldsChanged?.Invoke();
            txtComplemento.TextChanged += (x, y) => fieldsChanged?.Invoke();
            txtBairro.TextChanged += (x, y) => fieldsChanged?.Invoke();
            txtCidade.TextChanged += (x, y) => fieldsChanged?.Invoke();
            estados.SelectedIndexChanged += (x, y) => fieldsChanged?.Invoke();
        }

        public bool FieldsAreValid => TextsAreValid(txtLogradouro, txtBairro, txtCidade)
            && !string.IsNullOrEmpty(estados.Text);

        public Endereco Endereco
        {
            get
            {
                int? num = null;
                if (!string.IsNullOrEmpty(txtNumEndereco.Text))
                    num = int.Parse(txtNumEndereco.Text);

                return new Endereco(
                    txtLogradouro.Text,
                    num,
                    txtComplemento.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    estados.Text
                );
            }
            set
            {
                txtLogradouro.Text = value.Logradouro;
                txtNumEndereco.Text = value.Numero?.ToString();
                txtComplemento.Text = value.Complemento;
                txtBairro.Text = value.Bairro;
                txtCidade.Text = value.Cidade;
                estados.Text = value.Estado;
            }
        }

        #region Auxiliar Methods
        private bool TextIsValid(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }

        private bool TextsAreValid(params TextBox[] textBoxes)
        {
            foreach (TextBox box in textBoxes)
            {
                if (!TextIsValid(box))
                    return false;
            }

            return true;
        }
        #endregion
    }
}
