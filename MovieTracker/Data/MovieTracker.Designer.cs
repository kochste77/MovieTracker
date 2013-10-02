﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MovieTrackerModel", "aspnet_UsersMovie", "aspnet_Users", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MovieTracker.Data.aspnet_Users), "Movie", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MovieTracker.Data.Movie), true)]
[assembly: EdmRelationshipAttribute("MovieTrackerModel", "GenreMovie", "Genre", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MovieTracker.Data.Genre), "Movie", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MovieTracker.Data.Movie), true)]

#endregion

namespace MovieTracker.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class movietrackerEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new movietrackerEntities object using the connection string found in the 'movietrackerEntities' section of the application configuration file.
        /// </summary>
        public movietrackerEntities() : base("name=movietrackerEntities", "movietrackerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new movietrackerEntities object.
        /// </summary>
        public movietrackerEntities(string connectionString) : base(connectionString, "movietrackerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new movietrackerEntities object.
        /// </summary>
        public movietrackerEntities(EntityConnection connection) : base(connection, "movietrackerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<aspnet_Users> aspnet_Users
        {
            get
            {
                if ((_aspnet_Users == null))
                {
                    _aspnet_Users = base.CreateObjectSet<aspnet_Users>("aspnet_Users");
                }
                return _aspnet_Users;
            }
        }
        private ObjectSet<aspnet_Users> _aspnet_Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Movie> Movies
        {
            get
            {
                if ((_Movies == null))
                {
                    _Movies = base.CreateObjectSet<Movie>("Movies");
                }
                return _Movies;
            }
        }
        private ObjectSet<Movie> _Movies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Genre> Genres
        {
            get
            {
                if ((_Genres == null))
                {
                    _Genres = base.CreateObjectSet<Genre>("Genres");
                }
                return _Genres;
            }
        }
        private ObjectSet<Genre> _Genres;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the aspnet_Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToaspnet_Users(aspnet_Users aspnet_Users)
        {
            base.AddObject("aspnet_Users", aspnet_Users);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Movies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMovies(Movie movie)
        {
            base.AddObject("Movies", movie);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Genres EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGenres(Genre genre)
        {
            base.AddObject("Genres", genre);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovieTrackerModel", Name="aspnet_Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class aspnet_Users : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new aspnet_Users object.
        /// </summary>
        /// <param name="applicationId">Initial value of the ApplicationId property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="loweredUserName">Initial value of the LoweredUserName property.</param>
        /// <param name="isAnonymous">Initial value of the IsAnonymous property.</param>
        /// <param name="lastActivityDate">Initial value of the LastActivityDate property.</param>
        public static aspnet_Users Createaspnet_Users(global::System.Guid applicationId, global::System.Guid userId, global::System.String userName, global::System.String loweredUserName, global::System.Boolean isAnonymous, global::System.DateTime lastActivityDate)
        {
            aspnet_Users aspnet_Users = new aspnet_Users();
            aspnet_Users.ApplicationId = applicationId;
            aspnet_Users.UserId = userId;
            aspnet_Users.UserName = userName;
            aspnet_Users.LoweredUserName = loweredUserName;
            aspnet_Users.IsAnonymous = isAnonymous;
            aspnet_Users.LastActivityDate = lastActivityDate;
            return aspnet_Users;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                OnApplicationIdChanging(value);
                ReportPropertyChanging("ApplicationId");
                _ApplicationId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationId");
                OnApplicationIdChanged();
            }
        }
        private global::System.Guid _ApplicationId;
        partial void OnApplicationIdChanging(global::System.Guid value);
        partial void OnApplicationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoweredUserName
        {
            get
            {
                return _LoweredUserName;
            }
            set
            {
                OnLoweredUserNameChanging(value);
                ReportPropertyChanging("LoweredUserName");
                _LoweredUserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoweredUserName");
                OnLoweredUserNameChanged();
            }
        }
        private global::System.String _LoweredUserName;
        partial void OnLoweredUserNameChanging(global::System.String value);
        partial void OnLoweredUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MobileAlias
        {
            get
            {
                return _MobileAlias;
            }
            set
            {
                OnMobileAliasChanging(value);
                ReportPropertyChanging("MobileAlias");
                _MobileAlias = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MobileAlias");
                OnMobileAliasChanged();
            }
        }
        private global::System.String _MobileAlias;
        partial void OnMobileAliasChanging(global::System.String value);
        partial void OnMobileAliasChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAnonymous
        {
            get
            {
                return _IsAnonymous;
            }
            set
            {
                OnIsAnonymousChanging(value);
                ReportPropertyChanging("IsAnonymous");
                _IsAnonymous = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAnonymous");
                OnIsAnonymousChanged();
            }
        }
        private global::System.Boolean _IsAnonymous;
        partial void OnIsAnonymousChanging(global::System.Boolean value);
        partial void OnIsAnonymousChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastActivityDate
        {
            get
            {
                return _LastActivityDate;
            }
            set
            {
                OnLastActivityDateChanging(value);
                ReportPropertyChanging("LastActivityDate");
                _LastActivityDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastActivityDate");
                OnLastActivityDateChanged();
            }
        }
        private global::System.DateTime _LastActivityDate;
        partial void OnLastActivityDateChanging(global::System.DateTime value);
        partial void OnLastActivityDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MovieTrackerModel", "aspnet_UsersMovie", "Movie")]
        public EntityCollection<Movie> Movies
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Movie>("MovieTrackerModel.aspnet_UsersMovie", "Movie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Movie>("MovieTrackerModel.aspnet_UsersMovie", "Movie", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovieTrackerModel", Name="Genre")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Genre : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Genre object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Genre CreateGenre(global::System.Int32 id, global::System.String name)
        {
            Genre genre = new Genre();
            genre.Id = id;
            genre.Name = name;
            return genre;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MovieTrackerModel", "GenreMovie", "Movie")]
        public EntityCollection<Movie> Movies
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Movie>("MovieTrackerModel.GenreMovie", "Movie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Movie>("MovieTrackerModel.GenreMovie", "Movie", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovieTrackerModel", Name="Movie")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Movie : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="aspnet_UsersUserId">Initial value of the aspnet_UsersUserId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="rating">Initial value of the Rating property.</param>
        /// <param name="genreId">Initial value of the GenreId property.</param>
        public static Movie CreateMovie(global::System.Int32 id, global::System.Guid aspnet_UsersUserId, global::System.String name, global::System.Int16 rating, global::System.Int32 genreId)
        {
            Movie movie = new Movie();
            movie.Id = id;
            movie.aspnet_UsersUserId = aspnet_UsersUserId;
            movie.Name = name;
            movie.Rating = rating;
            movie.GenreId = genreId;
            return movie;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid aspnet_UsersUserId
        {
            get
            {
                return _aspnet_UsersUserId;
            }
            set
            {
                Onaspnet_UsersUserIdChanging(value);
                ReportPropertyChanging("aspnet_UsersUserId");
                _aspnet_UsersUserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("aspnet_UsersUserId");
                Onaspnet_UsersUserIdChanged();
            }
        }
        private global::System.Guid _aspnet_UsersUserId;
        partial void Onaspnet_UsersUserIdChanging(global::System.Guid value);
        partial void Onaspnet_UsersUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Directors
        {
            get
            {
                return _Directors;
            }
            set
            {
                OnDirectorsChanging(value);
                ReportPropertyChanging("Directors");
                _Directors = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Directors");
                OnDirectorsChanged();
            }
        }
        private global::System.String _Directors;
        partial void OnDirectorsChanging(global::System.String value);
        partial void OnDirectorsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Writers
        {
            get
            {
                return _Writers;
            }
            set
            {
                OnWritersChanging(value);
                ReportPropertyChanging("Writers");
                _Writers = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Writers");
                OnWritersChanged();
            }
        }
        private global::System.String _Writers;
        partial void OnWritersChanging(global::System.String value);
        partial void OnWritersChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Stars
        {
            get
            {
                return _Stars;
            }
            set
            {
                OnStarsChanging(value);
                ReportPropertyChanging("Stars");
                _Stars = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Stars");
                OnStarsChanged();
            }
        }
        private global::System.String _Stars;
        partial void OnStarsChanging(global::System.String value);
        partial void OnStarsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Rating
        {
            get
            {
                return _Rating;
            }
            set
            {
                OnRatingChanging(value);
                ReportPropertyChanging("Rating");
                _Rating = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Rating");
                OnRatingChanged();
            }
        }
        private global::System.Int16 _Rating;
        partial void OnRatingChanging(global::System.Int16 value);
        partial void OnRatingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GenreId
        {
            get
            {
                return _GenreId;
            }
            set
            {
                OnGenreIdChanging(value);
                ReportPropertyChanging("GenreId");
                _GenreId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GenreId");
                OnGenreIdChanged();
            }
        }
        private global::System.Int32 _GenreId;
        partial void OnGenreIdChanging(global::System.Int32 value);
        partial void OnGenreIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MovieTrackerModel", "aspnet_UsersMovie", "aspnet_Users")]
        public aspnet_Users aspnet_Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("MovieTrackerModel.aspnet_UsersMovie", "aspnet_Users").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("MovieTrackerModel.aspnet_UsersMovie", "aspnet_Users").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<aspnet_Users> aspnet_UsersReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_Users>("MovieTrackerModel.aspnet_UsersMovie", "aspnet_Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_Users>("MovieTrackerModel.aspnet_UsersMovie", "aspnet_Users", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MovieTrackerModel", "GenreMovie", "Genre")]
        public Genre Genre
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("MovieTrackerModel.GenreMovie", "Genre").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("MovieTrackerModel.GenreMovie", "Genre").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Genre> GenreReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("MovieTrackerModel.GenreMovie", "Genre");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Genre>("MovieTrackerModel.GenreMovie", "Genre", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
