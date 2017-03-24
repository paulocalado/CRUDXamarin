using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Contato> contatos;
        private ListView listaContatos;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            contatos = new List<Contato>();
            contatos.Add(new Contato() {nome = "Paulo", email = "paulo_calado@live.com" });
            contatos.Add(new Contato() {nome = "Lucas", email = "lucas@hotmail.com"});
            contatos.Add(new Contato() {nome = "Vinícius", email = "vinicius@hotmail.com" });
            contatos.Add(new Contato() {nome = "Italo", email = "italo@gmail.com" });
            contatos.Add(new Contato() {nome = "Thiago", email = "thiago@hotmail.com" });
            contatos.Add(new Contato() {nome = "Didjo", email ="diogene@hotmail.com" });
            contatos.Add(new Contato() {nome = "Renato", email = "renato@hotmail.com" });
            contatos.Add(new Contato() {nome = "Ewa", email = "ewa@hotmail.com" });
            contatos.Add(new Contato() {nome = "Teste", email = "teste@hotmail.com" });
            contatos.Add(new Contato() {nome = "Testando123", email = "testando123@hotmail.com" });
            contatos.Add(new Contato() {nome = "Alou Alou", email = "aloulolo@hotmail.com" });
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

           listaContatos = FindViewById<ListView>(Resource.Id.listaContatos);
            CustomListAdapter adapter = new CustomListAdapter(this, contatos);

            listaContatos.Adapter = adapter;

            listaContatos.ItemClick += ListaContatos_ItemClick;
        }

        private void ListaContatos_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, contatos[e.Position].nome, ToastLength.Long).Show();
        }
    }
}

