namespace digitalAgency.Domain.Common
{
    /// <summary>
    /// Tüm entity'lerin base sınıfı
    /// Soft Delete ve Audit Trail özellikleri içerir
    /// </summary>
    public abstract class BaseEntity 
    {
        public Guid Id { get; set; }

        // Audit Fields - Kim ne zaman oluşturdu/güncelledi?
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }  // Oluşturan kullanıcının ID'si veya username
        
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }  // Güncelleyen kullanıcının ID'si

        // Soft Delete Pattern - Data gerçekten silinmez, flag ile işaretlenir
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }  // Silen kullanıcının ID'si

        /// <summary>
        /// Soft delete işlemi
        /// </summary>
        public void SoftDelete(string deletedBy)
        {
            IsDeleted = true;
            DeletedDate = DateTime.UtcNow;
            DeletedBy = deletedBy;
        }

        /// <summary>
        /// Soft delete'i geri al (restore)
        /// </summary>
        public void Restore()
        {
            IsDeleted = false;
            DeletedDate = null;
            DeletedBy = null;
        }
    }
}
