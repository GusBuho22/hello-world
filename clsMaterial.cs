using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBiblioteca
{
    class clsMaterial
    {
        
        List<clsMaterial> listMaterial = new List<clsMaterial>();

        #region Propiedades
        
        private int _intIdMaterial;
        public int pintMaterial
        {
            get { return _intIdMaterial; }
            set { _intIdMaterial = value; }
        }

        private string _strNombre;
        public string pstrNombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strPropietario;
        public string pstrPropietario
        {
            get { return _strPropietario; }
            set { _strPropietario = value; }
        }

        private int _intTipo;
        public int pintTipo
        {
            get { return _intTipo; }
            set { _intTipo = value; }
        }

        #endregion

        public List<clsMaterial> gfListaMateriales()
        {
            int x=0;
            while(x <= 3)
            {
                clsMaterial objMaterial = new clsMaterial();
                objMaterial.pintMaterial = 1;
                objMaterial.pstrNombre = "Carlos";
                objMaterial.pstrPropietario = "Facultad de Economia";
                objMaterial.pintTipo = 2;
                listMaterial.Add(objMaterial);
                x++;

            }
            return listMaterial;
        }

    }
}
