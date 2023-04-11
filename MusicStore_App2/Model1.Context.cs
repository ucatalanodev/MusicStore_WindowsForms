﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStore_App2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class MusicStoreEntities : DbContext
    {
        public MusicStoreEntities()
            : base("name=MusicStoreEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersRole> UsersRole { get; set; }

        public virtual int AlbumAddOrEdit(Nullable<long> album_id, Nullable<long> artist_id, string album_title, string genre, string publ_year, string record_label, Nullable<double> price)
        {
            var album_idParameter = album_id.HasValue ?
                new ObjectParameter("album_id", album_id) :
                new ObjectParameter("album_id", typeof(long));

            var artist_idParameter = artist_id.HasValue ?
                new ObjectParameter("artist_id", artist_id) :
                new ObjectParameter("artist_id", typeof(long));

            var album_titleParameter = album_title != null ?
                new ObjectParameter("album_title", album_title) :
                new ObjectParameter("album_title", typeof(string));

            var genreParameter = genre != null ?
                new ObjectParameter("genre", genre) :
                new ObjectParameter("genre", typeof(string));

            var publ_yearParameter = publ_year != null ?
                new ObjectParameter("publ_year", publ_year) :
                new ObjectParameter("publ_year", typeof(string));

            var record_labelParameter = record_label != null ?
                new ObjectParameter("record_label", record_label) :
                new ObjectParameter("record_label", typeof(string));

            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlbumAddOrEdit", album_idParameter, artist_idParameter, album_titleParameter, genreParameter, publ_yearParameter, record_labelParameter, priceParameter);
        }

        public virtual int AlbumDeleteByID(Nullable<long> album_id)
        {
            var album_idParameter = album_id.HasValue ?
                new ObjectParameter("album_id", album_id) :
                new ObjectParameter("album_id", typeof(long));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlbumDeleteByID", album_idParameter);
        }

        public virtual int ArtistAddOrEdit(Nullable<long> artist_id, string artist_name, string artist_origin, string website, string social, Nullable<bool> is_band, Nullable<bool> is_active)
        {
            var artist_idParameter = artist_id.HasValue ?
                new ObjectParameter("artist_id", artist_id) :
                new ObjectParameter("artist_id", typeof(long));

            var artist_nameParameter = artist_name != null ?
                new ObjectParameter("artist_name", artist_name) :
                new ObjectParameter("artist_name", typeof(string));

            var artist_originParameter = artist_origin != null ?
                new ObjectParameter("artist_origin", artist_origin) :
                new ObjectParameter("artist_origin", typeof(string));

            var websiteParameter = website != null ?
                new ObjectParameter("website", website) :
                new ObjectParameter("website", typeof(string));

            var socialParameter = social != null ?
                new ObjectParameter("social", social) :
                new ObjectParameter("social", typeof(string));

            var is_bandParameter = is_band.HasValue ?
                new ObjectParameter("is_band", is_band) :
                new ObjectParameter("is_band", typeof(bool));

            var is_activeParameter = is_active.HasValue ?
                new ObjectParameter("is_active", is_active) :
                new ObjectParameter("is_active", typeof(bool));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ArtistAddOrEdit", artist_idParameter, artist_nameParameter, artist_originParameter, websiteParameter, socialParameter, is_bandParameter, is_activeParameter);
        }

        public virtual int ArtistDeleteByID(Nullable<long> artist_id)
        {
            var artist_idParameter = artist_id.HasValue ?
                new ObjectParameter("artist_id", artist_id) :
                new ObjectParameter("artist_id", typeof(long));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ArtistDeleteByID", artist_idParameter);
        }

        public virtual int CustomerAddOrEdit(Nullable<long> customer_id, string customer_name, string customer_address, string phone_number, string email, Nullable<bool> is_business)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(long));

            var customer_nameParameter = customer_name != null ?
                new ObjectParameter("customer_name", customer_name) :
                new ObjectParameter("customer_name", typeof(string));

            var customer_addressParameter = customer_address != null ?
                new ObjectParameter("customer_address", customer_address) :
                new ObjectParameter("customer_address", typeof(string));

            var phone_numberParameter = phone_number != null ?
                new ObjectParameter("phone_number", phone_number) :
                new ObjectParameter("phone_number", typeof(string));

            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));

            var is_businessParameter = is_business.HasValue ?
                new ObjectParameter("is_business", is_business) :
                new ObjectParameter("is_business", typeof(bool));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustomerAddOrEdit", customer_idParameter, customer_nameParameter, customer_addressParameter, phone_numberParameter, emailParameter, is_businessParameter);
        }

        public virtual int CustomerDeleteByID(Nullable<long> customer_id)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(long));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustomerDeleteByID", customer_idParameter);
        }

        public virtual int PurchaseAddOrEdit(Nullable<long> purchase_id, Nullable<long> album_id, Nullable<long> customer_id, string purchased_amount, Nullable<double> total_paid)
        {
            var purchase_idParameter = purchase_id.HasValue ?
                new ObjectParameter("purchase_id", purchase_id) :
                new ObjectParameter("purchase_id", typeof(long));

            var album_idParameter = album_id.HasValue ?
                new ObjectParameter("album_id", album_id) :
                new ObjectParameter("album_id", typeof(long));

            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(long));

            var purchased_amountParameter = purchased_amount != null ?
                new ObjectParameter("purchased_amount", purchased_amount) :
                new ObjectParameter("purchased_amount", typeof(string));

            var total_paidParameter = total_paid.HasValue ?
                new ObjectParameter("total_paid", total_paid) :
                new ObjectParameter("total_paid", typeof(double));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PurchaseAddOrEdit", purchase_idParameter, album_idParameter, customer_idParameter, purchased_amountParameter, total_paidParameter);
        }

        public virtual int PurchaseDeleteByID(Nullable<long> purchase_id)
        {
            var purchase_idParameter = purchase_id.HasValue ?
                new ObjectParameter("purchase_id", purchase_id) :
                new ObjectParameter("purchase_id", typeof(long));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PurchaseDeleteByID", purchase_idParameter);
        }
    }
}