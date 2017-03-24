using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class CustomListAdapter : BaseAdapter<Contato>
    {
        private List<Contato> itensLista;
        private Context context;

        public CustomListAdapter(Context cContext, List<Contato> cItensLista)
        {
            context = cContext;
            itensLista = cItensLista;
        }

        public override int Count
        {

            get { return itensLista.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Contato this[int position]
        {
            get { return itensLista[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.layout_listView, null, false);
            }

            TextView txtNomeEditar = row.FindViewById<TextView>(Resource.Id.txtNomeEditar);
            txtNomeEditar.Text = itensLista[position].nome;

            TextView txtEmailEditar = row.FindViewById<TextView>(Resource.Id.txtEmailEditar);
            txtEmailEditar.Text = itensLista[position].email;

            return row;
        }
    }
}