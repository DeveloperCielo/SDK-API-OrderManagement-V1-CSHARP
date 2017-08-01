/* 
 * LIO - Order Management API
 *
 * API de gerenciamento de pedidos da LIO.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse200
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Status do pedido.
        /// </summary>
        /// <value>Status do pedido.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum DRAFT for "DRAFT"
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT,
            
            /// <summary>
            /// Enum ENTERED for "ENTERED"
            /// </summary>
            [EnumMember(Value = "ENTERED")]
            ENTERED,
            
            /// <summary>
            /// Enum CANCELED for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED,
            
            /// <summary>
            /// Enum PAID for "PAID"
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID,
            
            /// <summary>
            /// Enum APPROVED for "APPROVED"
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED,
            
            /// <summary>
            /// Enum REJECTED for "REJECTED"
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED,
            
            /// <summary>
            /// Enum REENTERED for "RE_ENTERED"
            /// </summary>
            [EnumMember(Value = "RE_ENTERED")]
            REENTERED,
            
            /// <summary>
            /// Enum CLOSED for "CLOSED"
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED
        }

        /// <summary>
        /// Status do pedido.
        /// </summary>
        /// <value>Status do pedido.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse200() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="Id">UUID que identifica unicamente o pedido. (required).</param>
        /// <param name="Number">Número do pedido. Gerelmente esse número representa o identificador do pedido em um sistema externo através da integração com parceiros..</param>
        /// <param name="Reference">Referência do pedido. Utilizada para facilitar o acesso ou localização do mesmo..</param>
        /// <param name="Status">Status do pedido. (required).</param>
        /// <param name="CreatedAt">Data de criação do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) (required).</param>
        /// <param name="UpdatedAt">Data de última atualização do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) (required).</param>
        /// <param name="Items">Lista de itens contidos no pedido. (required).</param>
        /// <param name="Notes">Campo disponível para uso do Merchant para comunicação..</param>
        /// <param name="Transactions">Lista de transações de pagamento (ou outros tipos) efetuadas no pedido. (required).</param>
        /// <param name="Price">Valor total do pedido. Exemplo: O valor de R$ 10,00 é representado como 1000. (required).</param>
        /// <param name="Remaining">Valor restante do pagamento do pedido.Exemplo: O valor de R$ 10,00 é representado como 1000. (required).</param>
        public InlineResponse200(string Id = default(string), string Number = default(string), string Reference = default(string), StatusEnum? Status = default(StatusEnum?), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?), List<OrdersItems> Items = default(List<OrdersItems>), string Notes = default(string), List<OrdersTransactions> Transactions = default(List<OrdersTransactions>), int? Price = default(int?), int? Remaining = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Transactions" is required (not null)
            if (Transactions == null)
            {
                throw new InvalidDataException("Transactions is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Transactions = Transactions;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "Remaining" is required (not null)
            if (Remaining == null)
            {
                throw new InvalidDataException("Remaining is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Remaining = Remaining;
            }
            this.Number = Number;
            this.Reference = Reference;
            this.Notes = Notes;
        }
        
        /// <summary>
        /// UUID que identifica unicamente o pedido.
        /// </summary>
        /// <value>UUID que identifica unicamente o pedido.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Número do pedido. Gerelmente esse número representa o identificador do pedido em um sistema externo através da integração com parceiros.
        /// </summary>
        /// <value>Número do pedido. Gerelmente esse número representa o identificador do pedido em um sistema externo através da integração com parceiros.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Referência do pedido. Utilizada para facilitar o acesso ou localização do mesmo.
        /// </summary>
        /// <value>Referência do pedido. Utilizada para facilitar o acesso ou localização do mesmo.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }


        /// <summary>
        /// Data de criação do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)
        /// </summary>
        /// <value>Data de criação do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Data de última atualização do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)
        /// </summary>
        /// <value>Data de última atualização do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Lista de itens contidos no pedido.
        /// </summary>
        /// <value>Lista de itens contidos no pedido.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<OrdersItems> Items { get; set; }

        /// <summary>
        /// Campo disponível para uso do Merchant para comunicação.
        /// </summary>
        /// <value>Campo disponível para uso do Merchant para comunicação.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Lista de transações de pagamento (ou outros tipos) efetuadas no pedido.
        /// </summary>
        /// <value>Lista de transações de pagamento (ou outros tipos) efetuadas no pedido.</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<OrdersTransactions> Transactions { get; set; }

        /// <summary>
        /// Valor total do pedido. Exemplo: O valor de R$ 10,00 é representado como 1000.
        /// </summary>
        /// <value>Valor total do pedido. Exemplo: O valor de R$ 10,00 é representado como 1000.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }

        /// <summary>
        /// Valor restante do pagamento do pedido.Exemplo: O valor de R$ 10,00 é representado como 1000.
        /// </summary>
        /// <value>Valor restante do pagamento do pedido.Exemplo: O valor de R$ 10,00 é representado como 1000.</value>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public int? Remaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Transactions == other.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(other.Transactions)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Remaining == other.Remaining ||
                    this.Remaining != null &&
                    this.Remaining.Equals(other.Remaining)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Transactions != null)
                    hash = hash * 59 + this.Transactions.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}