// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the BillingProfileResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="BillingProfileConsumptionResource"/> from a <see cref="ResourceIdentifier"/> with a resource type of Microsoft.Billing/billingAccounts/billingProfiles.
    /// </summary>
    public partial class BillingProfileConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingProfileConsumptionResource"/> instance. </summary>
        /// <param name="billingAccountId"> The billingAccountId. </param>
        /// <param name="billingProfileId"> The billingProfileId. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string billingAccountId, string billingProfileId)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reservationTransactionsClientDiagnostics;
        private readonly ReservationTransactionsRestOperations _reservationTransactionsRestClient;
        private readonly ClientDiagnostics _eventsClientDiagnostics;
        private readonly EventsRestOperations _eventsRestClient;
        private readonly ClientDiagnostics _lotsClientDiagnostics;
        private readonly LotsRestOperations _lotsRestClient;
        private readonly ClientDiagnostics _creditsClientDiagnostics;
        private readonly CreditsRestOperations _creditsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingProfileConsumptionResource"/> class for mocking. </summary>
        protected BillingProfileConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingProfileConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationTransactionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _reservationTransactionsRestClient = new ReservationTransactionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _eventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _eventsRestClient = new EventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _lotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _lotsRestClient = new LotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _creditsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _creditsRestClient = new CreditsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingProfiles";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// List of transactions for reserved instances on billing profile scope. The refund transactions are posted along with its purchase transaction (i.e. in the purchase billing month). For example, The refund is requested in May 2021. This refund transaction will have event date as May 2021 but the billing month as April 2020 when the reservation purchase was made.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/reservationTransactions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationTransactions_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation transactions by date range. The properties/EventDate for start date and end date. The filter supports 'le' and  'ge'. Note: API returns data for the entire start date's and end date's billing month. For example, filter properties/eventDate+ge+2020-01-01+AND+properties/eventDate+le+2020-12-29 will include data for entire December 2020 month (i.e. will contain records for dates December 30 and 31). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionModernReservationTransaction"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionModernReservationTransaction> GetReservationTransactionsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationTransactionsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationTransactionsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ConsumptionModernReservationTransaction.DeserializeConsumptionModernReservationTransaction(e), _reservationTransactionsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetReservationTransactions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of transactions for reserved instances on billing profile scope. The refund transactions are posted along with its purchase transaction (i.e. in the purchase billing month). For example, The refund is requested in May 2021. This refund transaction will have event date as May 2021 but the billing month as April 2020 when the reservation purchase was made.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/reservationTransactions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationTransactions_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation transactions by date range. The properties/EventDate for start date and end date. The filter supports 'le' and  'ge'. Note: API returns data for the entire start date's and end date's billing month. For example, filter properties/eventDate+ge+2020-01-01+AND+properties/eventDate+le+2020-12-29 will include data for entire December 2020 month (i.e. will contain records for dates December 30 and 31). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionModernReservationTransaction"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionModernReservationTransaction> GetReservationTransactions(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationTransactionsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationTransactionsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ConsumptionModernReservationTransaction.DeserializeConsumptionModernReservationTransaction(e), _reservationTransactionsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetReservationTransactions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <returns> An async collection of <see cref="ConsumptionEventSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionEventSummary> GetEventsAsync(string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name, startDate, endDate);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name, startDate, endDate);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ConsumptionEventSummary.DeserializeConsumptionEventSummary(e), _eventsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetEvents", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the events that decrements Azure credits or Microsoft Azure consumption commitment for a billing account or a billing profile for a given start and end date.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startDate"> Start date. </param>
        /// <param name="endDate"> End date. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startDate"/> or <paramref name="endDate"/> is null. </exception>
        /// <returns> A collection of <see cref="ConsumptionEventSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionEventSummary> GetEvents(string startDate, string endDate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startDate, nameof(startDate));
            Argument.AssertNotNull(endDate, nameof(endDate));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name, startDate, endDate);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name, startDate, endDate);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ConsumptionEventSummary.DeserializeConsumptionEventSummary(e), _eventsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetEvents", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/lots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Lots_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionLotSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionLotSummary> GetLotsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _lotsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _lotsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ConsumptionLotSummary.DeserializeConsumptionLotSummary(e), _lotsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetLots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Azure credits for a billing account or a billing profile. The API is only supported for Microsoft Customer Agreements (MCA) billing accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/lots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Lots_ListByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionLotSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionLotSummary> GetLots(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _lotsRestClient.CreateListByBillingProfileRequest(Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _lotsRestClient.CreateListByBillingProfileNextPageRequest(nextLink, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ConsumptionLotSummary.DeserializeConsumptionLotSummary(e), _lotsClientDiagnostics, Pipeline, "BillingProfileConsumptionResource.GetLots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The credit summary by billingAccountId and billingProfileId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/credits/balanceSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionCreditSummary>> GetCreditAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _creditsClientDiagnostics.CreateScope("BillingProfileConsumptionResource.GetCredit");
            scope.Start();
            try
            {
                var response = await _creditsRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The credit summary by billingAccountId and billingProfileId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/providers/Microsoft.Consumption/credits/balanceSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionCreditSummary> GetCredit(CancellationToken cancellationToken = default)
        {
            using var scope = _creditsClientDiagnostics.CreateScope("BillingProfileConsumptionResource.GetCredit");
            scope.Start();
            try
            {
                var response = _creditsRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
