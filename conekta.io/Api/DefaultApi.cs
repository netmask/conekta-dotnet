using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using conekta.io.Resource;
using conekta.io.Service;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;

namespace conekta.io.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets all account events
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelEvent&gt;</returns>
        List<ModelEvent> EventsGet(Dictionary<String, Object> localVarQueryParams = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <param name="plan"></param>
        /// <returns>Plan</returns>
        Plan PlansPlanIdPut(string planId, Plan plan);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Plan</returns>
        Plan PlansPlanIdDelete(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> PlansPlanIdDeleteWithHttpInfo(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Plan</returns>
        Plan PlansPost(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> PlansPostWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Plan</returns>
        Plan PlansPut(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> PlansPutWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Subscription</returns>
        Subscription CustomersCustomerIdSubscriptionPut(string customerId, SubscriptionReference subscription);

        Customer CustomersCustomerIdPut(string customerId, BaseClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <param name="client"></param>
        /// <returns>Card</returns>
        Card CustomersCustomerIdCardsCardIdPut(string customerId, string cardId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>Card</returns>
        Card CustomersCustomerIdCardsCardIdPut(string customerId, string cardId);

        Card CustomersCustomerIdCardsCardIdDelete(string customerId, string cardId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Charge&gt;</returns>
        List<Charge> ChargesGet(Dictionary<string, string> query = null );

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Charge&gt;</returns>
        ApiResponse<List<Charge>> ChargesGetWithHttpInfo(Dictionary<string, string> query = null);

        /// <summary>
        /// Create a Charge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>Charge</returns>
        Charge ChargesPost(Charge body);

        /// <summary>
        /// Create a Charge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>ApiResponse of Charge</returns>
        ApiResponse<Charge> ChargesPostWithHttpInfo(Charge body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Charge</returns>
        Charge ChargesChargeIdGet(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>ApiResponse of Charge</returns>
        ApiResponse<Charge> ChargesChargeIdGetWithHttpInfo(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Charge</returns>
        Charge ChargesChargeIdCapturePost(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>ApiResponse of Charge</returns>
        ApiResponse<Charge> ChargesChargeIdCapturePostWithHttpInfo(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>Charge</returns>
        Charge ChargesChargeIdRefundPost(string chargeId, AmountQty amountQty = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>ApiResponse of Charge</returns>
        ApiResponse<Charge> ChargesChargeIdRefundPostWithHttpInfo(string chargeId, AmountQty amountQty = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>Customer</returns>
        Customer CustomersPost(BaseClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>ApiResponse of Customer</returns>
        ApiResponse<Customer> CustomersPostWithHttpInfo(BaseClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Plan</returns>
        Plan CustomersPlansPut(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> CustomersPlansPutWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Plan</returns>
        Plan CustomersPlansPost(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> CustomersPlansPostWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Plan</returns>
        Plan CustomersPlansPlanIdDelete(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>ApiResponse of Plan</returns>
        ApiResponse<Plan> CustomersPlansPlanIdDeleteWithHttpInfo(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Customer</returns>
        Customer CustomersCustomerIdPut(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Customer</returns>
        ApiResponse<Customer> CustomersCustomerIdPutWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Customer</returns>
        Customer CustomersCustomerIdDelete(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Customer</returns>
        ApiResponse<Customer> CustomersCustomerIdDeleteWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Card</returns>
        Card CustomersCustomerIdCardsPut(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>ApiResponse of Card</returns>
        ApiResponse<Card> CustomersCustomerIdCardsPutWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Card</returns>
        Card CustomersCustomerIdCardsPost(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>ApiResponse of Card</returns>
        ApiResponse<Card> CustomersCustomerIdCardsPostWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Card</returns>
        Card CustomersCustomerIdCardsDelete(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>ApiResponse of Card</returns>
        ApiResponse<Card> CustomersCustomerIdCardsDeleteWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Subscription</returns>
        Subscription CustomersCustomerIdSubscriptionPost(string customerId, SubscriptionReference subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> CustomersCustomerIdSubscriptionPostWithHttpInfo(string customerId, SubscriptionReference subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Subscription</returns>
        Subscription CustomersCustomerIdSubscriptionCancelPost(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> CustomersCustomerIdSubscriptionCancelPostWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Subscription</returns>
        Subscription CustomersCustomerIdSubscriptionPausePost(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> CustomersCustomerIdSubscriptionPausePostWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Subscription</returns>
        Subscription CustomersCustomerIdSubscriptionResumePost(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> CustomersCustomerIdSubscriptionResumePostWithHttpInfo(string customerId);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Charge&gt;</returns>
        System.Threading.Tasks.Task<List<Charge>> ChargesGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Charge&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Charge>>> ChargesGetAsyncWithHttpInfo();

        /// <summary>
        /// Create a Charge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>Task of Charge</returns>
        System.Threading.Tasks.Task<Charge> ChargesPostAsync(Charge body);

        /// <summary>
        /// Create a Charge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesPostAsyncWithHttpInfo(Charge body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of Charge</returns>
        System.Threading.Tasks.Task<Charge> ChargesChargeIdGetAsync(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdGetAsyncWithHttpInfo(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of Charge</returns>
        System.Threading.Tasks.Task<Charge> ChargesChargeIdCapturePostAsync(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdCapturePostAsyncWithHttpInfo(string chargeId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>Task of Charge</returns>
        System.Threading.Tasks.Task<Charge> ChargesChargeIdRefundPostAsync(string chargeId, AmountQty amountQty = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdRefundPostAsyncWithHttpInfo(string chargeId, AmountQty amountQty = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>Task of Customer</returns>
        System.Threading.Tasks.Task<Customer> CustomersPostAsync(BaseClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersPostAsyncWithHttpInfo(BaseClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of Plan</returns>
        System.Threading.Tasks.Task<Plan> CustomersPlansPutAsync(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPutAsyncWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of Plan</returns>
        System.Threading.Tasks.Task<Plan> CustomersPlansPostAsync(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPostAsyncWithHttpInfo(Plan subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Task of Plan</returns>
        System.Threading.Tasks.Task<Plan> CustomersPlansPlanIdDeleteAsync(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPlanIdDeleteAsyncWithHttpInfo(string planId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Customer</returns>
        System.Threading.Tasks.Task<Customer> CustomersCustomerIdPutAsync(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersCustomerIdPutAsyncWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Customer</returns>
        System.Threading.Tasks.Task<Customer> CustomersCustomerIdDeleteAsync(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersCustomerIdDeleteAsyncWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsPutAsync(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsPutAsyncWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsPostAsync(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsPostAsyncWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsDeleteAsync(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsDeleteAsyncWithHttpInfo(string customerId, TokenObject client);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionPostAsync(string customerId, SubscriptionReference subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionPostAsyncWithHttpInfo(string customerId, SubscriptionReference subscription);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionCancelPostAsync(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionCancelPostAsyncWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionPausePostAsync(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionPausePostAsyncWithHttpInfo(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionResumePostAsync(string customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// captures an payment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionResumePostAsyncWithHttpInfo(string customerId);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {

        /// <summary>
        ///  Gets all account events
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelEvent&gt;</returns>
        public List<ModelEvent> EventsGet(Dictionary<String, Object> localVarQueryParams = null)
        {
            ApiResponse<List<ModelEvent>> localVarResponse = EventsGetWithHttpInfo(localVarQueryParams);
            return localVarResponse.Data;
        }


        /// <summary>
        ///  Gets all account events
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelEvent&gt;</returns>
        public ApiResponse<List<ModelEvent>> EventsGetWithHttpInfo(Dictionary<String, Object> localVarQueryParams = null)
        {

            localVarQueryParams = localVarQueryParams ?? new Dictionary<String, Object>();

            var sanitizedLocalQueryParams = new Dictionary<String, List<String>>();

        
            foreach (var keyValuePair in localVarQueryParams)
            {

                sanitizedLocalQueryParams.Add(keyValuePair.Key, new List<string>());
                try
                {
                    var arrayParams = JArray.Parse(keyValuePair.Value.ToString());
                    foreach (var arrayParam in arrayParams)
                    {
                        sanitizedLocalQueryParams[keyValuePair.Key].Add(arrayParam.ToString());
                    }
                }
                catch (Exception)
                {
                    sanitizedLocalQueryParams[keyValuePair.Key].Add(keyValuePair.Value.ToString());
                }
            }

            var localVarPath = "/events";

            var localVarPathParams = new Dictionary<String, String>();
            
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, sanitizedLocalQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling EventsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling EventsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ModelEvent>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ModelEvent>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModelEvent>)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <param name="plan"></param> 
        /// <returns>Plan</returns>
        public Plan PlansPlanIdPut(string planId, Plan plan)
        {
            ApiResponse<Plan> localVarResponse = PlansPlanIdPutWithHttpInfo(planId, plan);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <param name="plan"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> PlansPlanIdPutWithHttpInfo(string planId, Plan plan)
        {

            // verify the required parameter 'planId' is set
            if (planId == null)
                throw new ApiException(400, "Missing required parameter 'planId' when calling DefaultApi->PlansPlanIdPut");

            // verify the required parameter 'plan' is set
            if (plan == null)
                throw new ApiException(400, "Missing required parameter 'plan' when calling DefaultApi->PlansPlanIdPut");


            var localVarPath = "/plans/{plan_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (planId != null) localVarPathParams.Add("plan_id", Configuration.ApiClient.ParameterToString(planId)); // path parameter




            if (plan.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(plan); // http body (model) parameter
            }
            else
            {
                localVarPostBody = plan; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling PlansPlanIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling PlansPlanIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <returns>Plan</returns>
        public Plan PlansPlanIdDelete(string planId)
        {
            ApiResponse<Plan> localVarResponse = PlansPlanIdDeleteWithHttpInfo(planId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> PlansPlanIdDeleteWithHttpInfo(string planId)
        {

            // verify the required parameter 'planId' is set
            if (planId == null)
                throw new ApiException(400, "Missing required parameter 'planId' when calling DefaultApi->PlansPlanIdDelete");


            var localVarPath = "/plans/{plan_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (planId != null) localVarPathParams.Add("plan_id", Configuration.ApiClient.ParameterToString(planId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling PlansPlanIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling PlansPlanIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>Plan</returns>
        public Plan PlansPost(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = PlansPostWithHttpInfo(subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> PlansPostWithHttpInfo(Plan subscription)
        {

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->PlansPost");


            var localVarPath = "/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling PlansPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling PlansPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>Plan</returns>
        public Plan PlansPut(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = PlansPutWithHttpInfo(subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> PlansPutWithHttpInfo(Plan subscription)
        {

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->PlansPut");


            var localVarPath = "/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling PlansPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling PlansPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }




        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="subscription"></param> 
        /// <returns>Subscription</returns>
        public Subscription CustomersCustomerIdSubscriptionPut(string customerId, SubscriptionReference subscription)
        {
            ApiResponse<Subscription> localVarResponse = CustomersCustomerIdSubscriptionPutWithHttpInfo(customerId, subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse<Subscription> CustomersCustomerIdSubscriptionPutWithHttpInfo(string customerId, SubscriptionReference subscription)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdSubscriptionPut");

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->CustomersCustomerIdSubscriptionPut");


            var localVarPath = "/customers/{customer_id}/subscription";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }
        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <param name="client"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsCardIdPut(string customerId, string cardId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsCardIdPutWithHttpInfo(customerId, cardId, client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsCardIdPutWithHttpInfo(string customerId, string cardId, TokenObject client)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsCardIdPut");

            // verify the required parameter 'cardId' is set
            if (cardId == null)
                throw new ApiException(400, "Missing required parameter 'cardId' when calling DefaultApi->CustomersCustomerIdCardsCardIdPut");

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersCustomerIdCardsCardIdPut");


            var localVarPath = "/customers/{customer_id}/cards/{card_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (cardId != null) localVarPathParams.Add("card_id", Configuration.ApiClient.ParameterToString(cardId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>Customer</returns>
        public Customer CustomersCustomerIdPut(string customerId, BaseClient client)
        {
            ApiResponse<Customer> localVarResponse = CustomersCustomerIdPutWithHttpInfo(customerId, client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Customer</returns>
        public ApiResponse<Customer> CustomersCustomerIdPutWithHttpInfo(string customerId, BaseClient client)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdPut");

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersCustomerIdPut");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Charge&gt;</returns>
        public List<Charge> ChargesGet(Dictionary<string, string> query = null)
        {
            ApiResponse<List<Charge>> localVarResponse = ChargesGetWithHttpInfo(query);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Charge&gt;</returns>
        public ApiResponse<List<Charge>> ChargesGetWithHttpInfo(Dictionary<string, string> query = null )
        {


            var sanitizedLocalQueryParams = new Dictionary<String, List<String>>();


            if (query != null)
            {
                foreach (var keyValuePair in query)
                {

                    sanitizedLocalQueryParams.Add(keyValuePair.Key, new List<string>());
                    try
                    {
                        var arrayParams = JArray.Parse(keyValuePair.Value.ToString());
                        foreach (var arrayParam in arrayParams)
                        {
                            sanitizedLocalQueryParams[keyValuePair.Key].Add(arrayParam.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        sanitizedLocalQueryParams[keyValuePair.Key].Add(keyValuePair.Value.ToString());
                    }
                }
            }

            var localVarPath = "/charges";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, sanitizedLocalQueryParams, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Charge>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Charge>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Charge>)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsCardIdPut(string customerId, string cardId)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsCardIdPutWithHttpInfo(customerId, cardId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsCardIdPutWithHttpInfo(string customerId, string cardId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsCardIdPut");

            // verify the required parameter 'cardId' is set
            if (cardId == null)
                throw new ApiException(400, "Missing required parameter 'cardId' when calling DefaultApi->CustomersCustomerIdCardsCardIdPut");


            var localVarPath = "/customers/{customer_id}/cards/{card_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (cardId != null) localVarPathParams.Add("card_id", Configuration.ApiClient.ParameterToString(cardId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Charge&gt;</returns>
        public async System.Threading.Tasks.Task<List<Charge>> ChargesGetAsync()
        {
            ApiResponse<List<Charge>> localVarResponse = await ChargesGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Charge&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Charge>>> ChargesGetAsyncWithHttpInfo()
        {


            var localVarPath = "/charges";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Charge>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Charge>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Charge>)));

        }

        /// <summary>
        /// Create a Charge 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param> 
        /// <returns>Charge</returns>
        public Charge ChargesPost(Charge body)
        {
            ApiResponse<Charge> localVarResponse = ChargesPostWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Charge 
        /// </summary>f
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param> 
        /// <returns>ApiResponse of Charge</returns>
        public ApiResponse<Charge> ChargesPostWithHttpInfo(Charge body)
        {

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->ChargesPost");


            var localVarPath = "/charges";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "application/vnd.conekta-v1.0.0+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }


        /// <summary>
        /// Create a Charge 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>Task of Charge</returns>
        public async System.Threading.Tasks.Task<Charge> ChargesPostAsync(Charge body)
        {
            ApiResponse<Charge> localVarResponse = await ChargesPostAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Charge 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Charge object</param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesPostAsyncWithHttpInfo(Charge body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ChargesPost");


            var localVarPath = "/charges";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "application/vnd.conekta-v1.0.0+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <returns>Charge</returns>
        public Charge ChargesChargeIdGet(string chargeId)
        {
            ApiResponse<Charge> localVarResponse = ChargesChargeIdGetWithHttpInfo(chargeId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <returns>ApiResponse of Charge</returns>
        public ApiResponse<Charge> ChargesChargeIdGetWithHttpInfo(string chargeId)
        {

            // verify the required parameter 'chargeId' is set
            if (chargeId == null)
                throw new ApiException(400, "Missing required parameter 'chargeId' when calling DefaultApi->ChargesChargeIdGet");


            var localVarPath = "/charges/{charge_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of Charge</returns>
        public async System.Threading.Tasks.Task<Charge> ChargesChargeIdGetAsync(string chargeId)
        {
            ApiResponse<Charge> localVarResponse = await ChargesChargeIdGetAsyncWithHttpInfo(chargeId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdGetAsyncWithHttpInfo(string chargeId)
        {
            // verify the required parameter 'chargeId' is set
            if (chargeId == null) throw new ApiException(400, "Missing required parameter 'chargeId' when calling ChargesChargeIdGet");


            var localVarPath = "/charges/{charge_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <returns>Charge</returns>
        public Charge ChargesChargeIdCapturePost(string chargeId)
        {
            ApiResponse<Charge> localVarResponse = ChargesChargeIdCapturePostWithHttpInfo(chargeId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <returns>ApiResponse of Charge</returns>
        public ApiResponse<Charge> ChargesChargeIdCapturePostWithHttpInfo(string chargeId)
        {

            // verify the required parameter 'chargeId' is set
            if (chargeId == null)
                throw new ApiException(400, "Missing required parameter 'chargeId' when calling DefaultApi->ChargesChargeIdCapturePost");


            var localVarPath = "/charges/{charge_id}/capture";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdCapturePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdCapturePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of Charge</returns>
        public async System.Threading.Tasks.Task<Charge> ChargesChargeIdCapturePostAsync(string chargeId)
        {
            ApiResponse<Charge> localVarResponse = await ChargesChargeIdCapturePostAsyncWithHttpInfo(chargeId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdCapturePostAsyncWithHttpInfo(string chargeId)
        {
            // verify the required parameter 'chargeId' is set
            if (chargeId == null) throw new ApiException(400, "Missing required parameter 'chargeId' when calling ChargesChargeIdCapturePost");


            var localVarPath = "/charges/{charge_id}/capture";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdCapturePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdCapturePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <param name="amountQty"></param> 
        /// <returns>Charge</returns>
        public Charge ChargesChargeIdRefundPost(string chargeId, AmountQty amountQty = null)
        {
            ApiResponse<Charge> localVarResponse = ChargesChargeIdRefundPostWithHttpInfo(chargeId, amountQty);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param> 
        /// <param name="amountQty"></param> 
        /// <returns>ApiResponse of Charge</returns>
        public ApiResponse<Charge> ChargesChargeIdRefundPostWithHttpInfo(string chargeId, AmountQty amountQty = null)
        {

            // verify the required parameter 'chargeId' is set
            if (chargeId == null)
                throw new ApiException(400, "Missing required parameter 'chargeId' when calling DefaultApi->ChargesChargeIdRefundPost");


            var localVarPath = "/charges/{charge_id}/refund";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter




            if (amountQty.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(amountQty); // http body (model) parameter
            }
            else
            {
                localVarPostBody = amountQty; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdRefundPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdRefundPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>Task of Charge</returns>
        public async System.Threading.Tasks.Task<Charge> ChargesChargeIdRefundPostAsync(string chargeId, AmountQty amountQty = null)
        {
            ApiResponse<Charge> localVarResponse = await ChargesChargeIdRefundPostAsyncWithHttpInfo(chargeId, amountQty);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chargeId"></param>
        /// <param name="amountQty"></param>
        /// <returns>Task of ApiResponse (Charge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Charge>> ChargesChargeIdRefundPostAsyncWithHttpInfo(string chargeId, AmountQty amountQty = null)
        {
            // verify the required parameter 'chargeId' is set
            if (chargeId == null) throw new ApiException(400, "Missing required parameter 'chargeId' when calling ChargesChargeIdRefundPost");


            var localVarPath = "/charges/{charge_id}/refund";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chargeId != null) localVarPathParams.Add("charge_id", Configuration.ApiClient.ParameterToString(chargeId)); // path parameter




            if (amountQty.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(amountQty); // http body (model) parameter
            }
            else
            {
                localVarPostBody = amountQty; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdRefundPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ChargesChargeIdRefundPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Charge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Charge)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Charge)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param> 
        /// <returns>Customer</returns>
        public Customer CustomersPost(BaseClient client)
        {
            ApiResponse<Customer> localVarResponse = CustomersPostWithHttpInfo(client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Customer</returns>
        public ApiResponse<Customer> CustomersPostWithHttpInfo(BaseClient client)
        {

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersPost");


            var localVarPath = "/customers";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>Task of Customer</returns>
        public async System.Threading.Tasks.Task<Customer> CustomersPostAsync(BaseClient client)
        {
            ApiResponse<Customer> localVarResponse = await CustomersPostAsyncWithHttpInfo(client);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersPostAsyncWithHttpInfo(BaseClient client)
        {
            // verify the required parameter 'client' is set
            if (client == null) throw new ApiException(400, "Missing required parameter 'client' when calling CustomersPost");


            var localVarPath = "/customers";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>Plan</returns>
        public Plan CustomersPlansPut(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = CustomersPlansPutWithHttpInfo(subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> CustomersPlansPutWithHttpInfo(Plan subscription)
        {

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->CustomersPlansPut");


            var localVarPath = "/customers/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of Plan</returns>
        public async System.Threading.Tasks.Task<Plan> CustomersPlansPutAsync(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = await CustomersPlansPutAsyncWithHttpInfo(subscription);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPutAsyncWithHttpInfo(Plan subscription)
        {
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling CustomersPlansPut");


            var localVarPath = "/customers/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>Plan</returns>
        public Plan CustomersPlansPost(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = CustomersPlansPostWithHttpInfo(subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> CustomersPlansPostWithHttpInfo(Plan subscription)
        {

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->CustomersPlansPost");


            var localVarPath = "/customers/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of Plan</returns>
        public async System.Threading.Tasks.Task<Plan> CustomersPlansPostAsync(Plan subscription)
        {
            ApiResponse<Plan> localVarResponse = await CustomersPlansPostAsyncWithHttpInfo(subscription);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPostAsyncWithHttpInfo(Plan subscription)
        {
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling CustomersPlansPost");


            var localVarPath = "/customers/plans";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <returns>Plan</returns>
        public Plan CustomersPlansPlanIdDelete(string planId)
        {
            ApiResponse<Plan> localVarResponse = CustomersPlansPlanIdDeleteWithHttpInfo(planId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param> 
        /// <returns>ApiResponse of Plan</returns>
        public ApiResponse<Plan> CustomersPlansPlanIdDeleteWithHttpInfo(string planId)
        {

            // verify the required parameter 'planId' is set
            if (planId == null)
                throw new ApiException(400, "Missing required parameter 'planId' when calling DefaultApi->CustomersPlansPlanIdDelete");


            var localVarPath = "/customers/plans/{plan_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (planId != null) localVarPathParams.Add("plan_id", Configuration.ApiClient.ParameterToString(planId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPlanIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPlanIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Task of Plan</returns>
        public async System.Threading.Tasks.Task<Plan> CustomersPlansPlanIdDeleteAsync(string planId)
        {
            ApiResponse<Plan> localVarResponse = await CustomersPlansPlanIdDeleteAsyncWithHttpInfo(planId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="planId"></param>
        /// <returns>Task of ApiResponse (Plan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Plan>> CustomersPlansPlanIdDeleteAsyncWithHttpInfo(string planId)
        {
            // verify the required parameter 'planId' is set
            if (planId == null) throw new ApiException(400, "Missing required parameter 'planId' when calling CustomersPlansPlanIdDelete");


            var localVarPath = "/customers/plans/{plan_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (planId != null) localVarPathParams.Add("plan_id", Configuration.ApiClient.ParameterToString(planId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPlanIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersPlansPlanIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Plan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Plan)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Plan)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>Customer</returns>
        public Customer CustomersCustomerIdPut(string customerId)
        {
            ApiResponse<Customer> localVarResponse = CustomersCustomerIdPutWithHttpInfo(customerId);
            return localVarResponse.Data;
        }


        public Customer CustomersCustomerIdGet(string customerId)
        {
            ApiResponse<Customer> localVarResponse = CustomersCustomerIdGetWithHttpInfo(customerId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Customer</returns>
        public ApiResponse<Customer> CustomersCustomerIdGetWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdPut");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Customer</returns>
        public ApiResponse<Customer> CustomersCustomerIdPutWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdPut");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Customer</returns>
        public async System.Threading.Tasks.Task<Customer> CustomersCustomerIdPutAsync(string customerId)
        {
            ApiResponse<Customer> localVarResponse = await CustomersCustomerIdPutAsyncWithHttpInfo(customerId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersCustomerIdPutAsyncWithHttpInfo(string customerId)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdPut");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>Customer</returns>
        public Customer CustomersCustomerIdDelete(string customerId)
        {
            ApiResponse<Customer> localVarResponse = CustomersCustomerIdDeleteWithHttpInfo(customerId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Customer</returns>
        public ApiResponse<Customer> CustomersCustomerIdDeleteWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdDelete");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Customer</returns>
        public async System.Threading.Tasks.Task<Customer> CustomersCustomerIdDeleteAsync(string customerId)
        {
            ApiResponse<Customer> localVarResponse = await CustomersCustomerIdDeleteAsyncWithHttpInfo(customerId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Customer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Customer>> CustomersCustomerIdDeleteAsyncWithHttpInfo(string customerId)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdDelete");


            var localVarPath = "/customers/{customer_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Customer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Customer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Customer)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsPut(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsPutWithHttpInfo(customerId, client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsPutWithHttpInfo(string customerId, TokenObject client)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsPut");

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersCustomerIdCardsPut");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        public async System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsPutAsync(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = await CustomersCustomerIdCardsPutAsyncWithHttpInfo(customerId, client);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsPutAsyncWithHttpInfo(string customerId, TokenObject client)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdCardsPut");
            // verify the required parameter 'client' is set
            if (client == null) throw new ApiException(400, "Missing required parameter 'client' when calling CustomersCustomerIdCardsPut");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsPost(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsPostWithHttpInfo(customerId, client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsPostWithHttpInfo(string customerId, TokenObject client)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsPost");

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersCustomerIdCardsPost");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        public async System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsPostAsync(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = await CustomersCustomerIdCardsPostAsyncWithHttpInfo(customerId, client);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsPostAsyncWithHttpInfo(string customerId, TokenObject client)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdCardsPost");
            // verify the required parameter 'client' is set
            if (client == null) throw new ApiException(400, "Missing required parameter 'client' when calling CustomersCustomerIdCardsPost");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsDelete(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsDeleteWithHttpInfo(customerId, client);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="client"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsDeleteWithHttpInfo(string customerId, TokenObject client)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsDelete");

            // verify the required parameter 'client' is set
            if (client == null)
                throw new ApiException(400, "Missing required parameter 'client' when calling DefaultApi->CustomersCustomerIdCardsDelete");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of Card</returns>
        public async System.Threading.Tasks.Task<Card> CustomersCustomerIdCardsDeleteAsync(string customerId, TokenObject client)
        {
            ApiResponse<Card> localVarResponse = await CustomersCustomerIdCardsDeleteAsyncWithHttpInfo(customerId, client);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="client"></param>
        /// <returns>Task of ApiResponse (Card)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Card>> CustomersCustomerIdCardsDeleteAsyncWithHttpInfo(string customerId, TokenObject client)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdCardsDelete");
            // verify the required parameter 'client' is set
            if (client == null) throw new ApiException(400, "Missing required parameter 'client' when calling CustomersCustomerIdCardsDelete");


            var localVarPath = "/customers/{customer_id}/cards";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (client.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(client); // http body (model) parameter
            }
            else
            {
                localVarPostBody = client; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="subscription"></param> 
        /// <returns>Subscription</returns>
        public Subscription CustomersCustomerIdSubscriptionPost(string customerId, SubscriptionReference subscription)
        {
            ApiResponse<Subscription> localVarResponse = CustomersCustomerIdSubscriptionPostWithHttpInfo(customerId, subscription);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="subscription"></param> 
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse<Subscription> CustomersCustomerIdSubscriptionPostWithHttpInfo(string customerId, SubscriptionReference subscription)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdSubscriptionPost");

            // verify the required parameter 'subscription' is set
            if (subscription == null)
                throw new ApiException(400, "Missing required parameter 'subscription' when calling DefaultApi->CustomersCustomerIdSubscriptionPost");


            var localVarPath = "/customers/{customer_id}/subscription";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }

            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionPostAsync(string customerId, SubscriptionReference subscription)
        {
            ApiResponse<Subscription> localVarResponse = await CustomersCustomerIdSubscriptionPostAsyncWithHttpInfo(customerId, subscription);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="subscription"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionPostAsyncWithHttpInfo(string customerId, SubscriptionReference subscription)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdSubscriptionPost");
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling CustomersCustomerIdSubscriptionPost");


            var localVarPath = "/customers/{customer_id}/subscription";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter




            if (subscription.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(subscription); // http body (model) parameter
            }
            else
            {
                localVarPostBody = subscription; // byte array
            }


            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>Subscription</returns>
        public Subscription CustomersCustomerIdSubscriptionCancelPost(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = CustomersCustomerIdSubscriptionCancelPostWithHttpInfo(customerId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse<Subscription> CustomersCustomerIdSubscriptionCancelPostWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdSubscriptionCancelPost");


            var localVarPath = "/customers/{customer_id}/subscription/cancel";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionCancelPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionCancelPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionCancelPostAsync(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = await CustomersCustomerIdSubscriptionCancelPostAsyncWithHttpInfo(customerId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionCancelPostAsyncWithHttpInfo(string customerId)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdSubscriptionCancelPost");


            var localVarPath = "/customers/{customer_id}/subscription/cancel";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionCancelPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionCancelPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>Subscription</returns>
        public Subscription CustomersCustomerIdSubscriptionPausePost(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = CustomersCustomerIdSubscriptionPausePostWithHttpInfo(customerId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse<Subscription> CustomersCustomerIdSubscriptionPausePostWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdSubscriptionPausePost");


            var localVarPath = "/customers/{customer_id}/subscription/pause";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPausePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPausePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>Card</returns>
        public Card CustomersCustomerIdCardsCardIdDelete(string customerId, string cardId)
        {
            ApiResponse<Card> localVarResponse = CustomersCustomerIdCardsCardIdDeleteWithHttpInfo(customerId, cardId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>ApiResponse of Card</returns>
        public ApiResponse<Card> CustomersCustomerIdCardsCardIdDeleteWithHttpInfo(string customerId, string cardId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdCardsCardIdDelete");

            // verify the required parameter 'cardId' is set
            if (cardId == null)
                throw new ApiException(400, "Missing required parameter 'cardId' when calling DefaultApi->CustomersCustomerIdCardsCardIdDelete");


            var localVarPath = "/customers/{customer_id}/cards/{card_id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (cardId != null) localVarPathParams.Add("card_id", Configuration.ApiClient.ParameterToString(cardId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdCardsCardIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Card>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Card)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Card)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionPausePostAsync(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = await CustomersCustomerIdSubscriptionPausePostAsyncWithHttpInfo(customerId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionPausePostAsyncWithHttpInfo(string customerId)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdSubscriptionPausePost");


            var localVarPath = "/customers/{customer_id}/subscription/pause";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPausePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionPausePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>Subscription</returns>
        public Subscription CustomersCustomerIdSubscriptionResumePost(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = CustomersCustomerIdSubscriptionResumePostWithHttpInfo(customerId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse<Subscription> CustomersCustomerIdSubscriptionResumePostWithHttpInfo(string customerId)
        {

            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling DefaultApi->CustomersCustomerIdSubscriptionResumePost");


            var localVarPath = "/customers/{customer_id}/subscription/resume";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter






            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionResumePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionResumePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }


        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> CustomersCustomerIdSubscriptionResumePostAsync(string customerId)
        {
            ApiResponse<Subscription> localVarResponse = await CustomersCustomerIdSubscriptionResumePostAsyncWithHttpInfo(customerId);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  captures an payment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Subscription>> CustomersCustomerIdSubscriptionResumePostAsyncWithHttpInfo(string customerId)
        {
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersCustomerIdSubscriptionResumePost");


            var localVarPath = "/customers/{customer_id}/subscription/resume";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter







            // authentication (conekta_api_key) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionResumePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CustomersCustomerIdSubscriptionResumePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));

        }

        private string Base64Encode(string v)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(v));
        }
    }


}
