﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using RESTFulSense.Models;
using Tynamix.ObjectFiller;
using Xunit;

namespace RESTFulSense.Tests.Controllers
{
    public partial class RESTFulControllerTests
    {
        [Fact]
        public void ShouldReturnValidationProblemDetailOnBadRequest()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = inputException.Message,
            };

            var expectedBadRequestObjectResult =
                new BadRequestObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);
                
                expectedProblemDetail.Errors.Add(
                    key: item.Key, 
                    value: item.Value.ToArray());
            }

            // when
            BadRequestObjectResult badRequestObjectResult =
                this.restfulController.BadRequest(inputException);

            // then
            badRequestObjectResult.Should()
                .BeEquivalentTo(expectedBadRequestObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnUnathorized()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status401Unauthorized,
                Type = "https://tools.ietf.org/html/rfc7235#section-3.1",
                Title = inputException.Message,
            };

            var expectedUnauthorizedObjectResult =
                new UnauthorizedObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            UnauthorizedObjectResult unauthorizedObjectResult =
                this.restfulController.Unauthorized(inputException);

            // then
            unauthorizedObjectResult.Should()
                .BeEquivalentTo(expectedUnauthorizedObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnPaymentRequired()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status402PaymentRequired,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.2",
                Title = inputException.Message,
            };

            var expectedPaymentRequiredObjectResult =
                new PaymentRequiredObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            PaymentRequiredObjectResult paymentRequiredObjectResult =
                this.restfulController.PaymentRequired(inputException);

            // then
            paymentRequiredObjectResult.Should()
                .BeEquivalentTo(expectedPaymentRequiredObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnForbidden()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status403Forbidden,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.3",
                Title = inputException.Message,
            };

            var expectedForbiddenObjectResult =
                new ForbiddenObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            ForbiddenObjectResult forbiddenObjectResult =
                this.restfulController.Forbidden(inputException);

            // then
            forbiddenObjectResult.Should()
                .BeEquivalentTo(expectedForbiddenObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnNotFound()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status404NotFound,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                Title = inputException.Message,
            };

            var expectedNotFoundObjectResult =
                new NotFoundObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            NotFoundObjectResult notFoundObjectResult =
                this.restfulController.NotFound(inputException);

            // then
            notFoundObjectResult.Should()
                .BeEquivalentTo(expectedNotFoundObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnMethodNotAllowed()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status405MethodNotAllowed,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.5",
                Title = inputException.Message,
            };

            var expectedMethodNotAllowedObjectResult =
                new MethodNotAllowedObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            MethodNotAllowedObjectResult methodNotAllowedObjectResult =
                this.restfulController.MethodNotAllowed(inputException);

            // then
            methodNotAllowedObjectResult.Should()
                .BeEquivalentTo(expectedMethodNotAllowedObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnNotAcceptable()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status406NotAcceptable,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.6",
                Title = inputException.Message,
            };

            var expectedNotAcceptableObjectResult =
                new NotAcceptableObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            NotAcceptableObjectResult notAcceptableObjectResult =
                this.restfulController.NotAcceptable(inputException);

            // then
            notAcceptableObjectResult.Should()
                .BeEquivalentTo(expectedNotAcceptableObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnProxyAuthenticationRequired()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status407ProxyAuthenticationRequired,
                Type = "https://tools.ietf.org/html/rfc7235#section-3.2",
                Title = inputException.Message,
            };

            var expectedProxyAuthenticationRequiredObjectResult =
                new ProxyAuthenticationRequiredObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            ProxyAuthenticationRequiredObjectResult proxyAuthenticationRequiredObjectResult =
                this.restfulController.ProxyAuthenticationRequired(inputException);

            // then
            proxyAuthenticationRequiredObjectResult.Should()
                .BeEquivalentTo(expectedProxyAuthenticationRequiredObjectResult);
        }

        [Fact]
        public void ShouldReturnValidationProblemDetailOnRequestTimeout()
        {
            // given
            Dictionary<string, List<string>> randomDictionary =
                CreateRandomDictionary();

            var inputException = new Exception();

            var expectedProblemDetail = new ValidationProblemDetails
            {
                Status = StatusCodes.Status408RequestTimeout,
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.7",
                Title = inputException.Message,
            };

            var expectedRequestTimeoutObjectResult =
                new RequestTimeoutObjectResult(expectedProblemDetail);

            foreach (KeyValuePair<string, List<string>> item in randomDictionary)
            {
                inputException.Data.Add(item.Key, item.Value);

                expectedProblemDetail.Errors.Add(
                    key: item.Key,
                    value: item.Value.ToArray());
            }

            // when
            RequestTimeoutObjectResult requestTimeoutObjectResult =
                this.restfulController.RequestTimeout(inputException);

            // then
            requestTimeoutObjectResult.Should()
                .BeEquivalentTo(expectedRequestTimeoutObjectResult);
        }

        public static Dictionary<string, List<string>> CreateRandomDictionary()
        {
            var filler = new Filler<Dictionary<string, List<string>>>();

            return filler.Create();
        }
    }
}