﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestyJednostkowe.Magazyn_wcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Magazyn_wcf.IWCFService")]
    public interface IWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajUtwor", ReplyAction="http://tempuri.org/IWCFService/dodajUtworResponse")]
        void dodajUtwor(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajUtwor", ReplyAction="http://tempuri.org/IWCFService/dodajUtworResponse")]
        System.Threading.Tasks.Task dodajUtworAsync(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajAlbum", ReplyAction="http://tempuri.org/IWCFService/dodajAlbumResponse")]
        void dodajAlbum(int id_albumu, string nazwa_albumu, float dlugosc_albumu, int wydawnictwo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajAlbum", ReplyAction="http://tempuri.org/IWCFService/dodajAlbumResponse")]
        System.Threading.Tasks.Task dodajAlbumAsync(int id_albumu, string nazwa_albumu, float dlugosc_albumu, int wydawnictwo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajWydawnictwo", ReplyAction="http://tempuri.org/IWCFService/dodajWydawnictwoResponse")]
        void dodajWydawnictwo(int id, string nazwa, int rok_zal, string wlasciciel, string kraj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/dodajWydawnictwo", ReplyAction="http://tempuri.org/IWCFService/dodajWydawnictwoResponse")]
        System.Threading.Tasks.Task dodajWydawnictwoAsync(int id, string nazwa, int rok_zal, string wlasciciel, string kraj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunWydawnictwo", ReplyAction="http://tempuri.org/IWCFService/usunWydawnictwoResponse")]
        void usunWydawnictwo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunWydawnictwo", ReplyAction="http://tempuri.org/IWCFService/usunWydawnictwoResponse")]
        System.Threading.Tasks.Task usunWydawnictwoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunUtwor", ReplyAction="http://tempuri.org/IWCFService/usunUtworResponse")]
        void usunUtwor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunUtwor", ReplyAction="http://tempuri.org/IWCFService/usunUtworResponse")]
        System.Threading.Tasks.Task usunUtworAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunAlbum", ReplyAction="http://tempuri.org/IWCFService/usunAlbumResponse")]
        void usunAlbum(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/usunAlbum", ReplyAction="http://tempuri.org/IWCFService/usunAlbumResponse")]
        System.Threading.Tasks.Task usunAlbumAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFServiceChannel : TestyJednostkowe.Magazyn_wcf.IWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFServiceClient : System.ServiceModel.ClientBase<TestyJednostkowe.Magazyn_wcf.IWCFService>, TestyJednostkowe.Magazyn_wcf.IWCFService {
        
        public WCFServiceClient() {
        }
        
        public WCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void dodajUtwor(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu) {
            base.Channel.dodajUtwor(id, tytul, wykonawca, dlugosc, rok_wydania, id_albumu);
        }
        
        public System.Threading.Tasks.Task dodajUtworAsync(int id, string tytul, string wykonawca, float dlugosc, int rok_wydania, int id_albumu) {
            return base.Channel.dodajUtworAsync(id, tytul, wykonawca, dlugosc, rok_wydania, id_albumu);
        }
        
        public void dodajAlbum(int id_albumu, string nazwa_albumu, float dlugosc_albumu, int wydawnictwo) {
            base.Channel.dodajAlbum(id_albumu, nazwa_albumu, dlugosc_albumu, wydawnictwo);
        }
        
        public System.Threading.Tasks.Task dodajAlbumAsync(int id_albumu, string nazwa_albumu, float dlugosc_albumu, int wydawnictwo) {
            return base.Channel.dodajAlbumAsync(id_albumu, nazwa_albumu, dlugosc_albumu, wydawnictwo);
        }
        
        public void dodajWydawnictwo(int id, string nazwa, int rok_zal, string wlasciciel, string kraj) {
            base.Channel.dodajWydawnictwo(id, nazwa, rok_zal, wlasciciel, kraj);
        }
        
        public System.Threading.Tasks.Task dodajWydawnictwoAsync(int id, string nazwa, int rok_zal, string wlasciciel, string kraj) {
            return base.Channel.dodajWydawnictwoAsync(id, nazwa, rok_zal, wlasciciel, kraj);
        }
        
        public void usunWydawnictwo(int id) {
            base.Channel.usunWydawnictwo(id);
        }
        
        public System.Threading.Tasks.Task usunWydawnictwoAsync(int id) {
            return base.Channel.usunWydawnictwoAsync(id);
        }
        
        public void usunUtwor(int id) {
            base.Channel.usunUtwor(id);
        }
        
        public System.Threading.Tasks.Task usunUtworAsync(int id) {
            return base.Channel.usunUtworAsync(id);
        }
        
        public void usunAlbum(int id) {
            base.Channel.usunAlbum(id);
        }
        
        public System.Threading.Tasks.Task usunAlbumAsync(int id) {
            return base.Channel.usunAlbumAsync(id);
        }
    }
}
