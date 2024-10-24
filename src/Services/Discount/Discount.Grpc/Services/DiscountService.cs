﻿using Discount.Grpc.Models;
using Grpc.Core;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Discount.Grpc.Services;

public class DiscountService()
    : DiscountProtoService.DiscountProtoServiceBase
{
    public override Task<CouponModel> GetDiscount(GetDiscountRequest request, ServerCallContext context)
    {
        //var coupon = await dbContext
        //    .Coupons
        //    .FirstOrDefaultAsync(x => x.ProductName == request.ProductName);
        //if (coupon is null)
        //    coupon = new Coupon { ProductName = "No Discount", Amount = 0, Description = "No Discount Desc" };

        //logger.LogInformation("Discount is retrieved for ProductName : {productName}, Amount : {amount}", coupon.ProductName, coupon.Amount);

        //var couponModel = coupon.Adapt<CouponModel>();
        //return couponModel;
        return base.GetDiscount(request, context);
    }

    public override Task<CouponModel> CreateDiscount(CreateDiscountRequest request, ServerCallContext context)
    {
        //var coupon = request.Coupon.Adapt<Coupon>();
        //if (coupon is null)
        //    throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

        //dbContext.Coupons.Add(coupon);
        //await dbContext.SaveChangesAsync();

        //logger.LogInformation("Discount is successfully created. ProductName : {ProductName}", coupon.ProductName);

        //var couponModel = coupon.Adapt<CouponModel>();
        //return couponModel;
        return base.CreateDiscount(request, context);
    }


    public override Task<CouponModel> UpdateDiscount(UpdateDiscountRequest request, ServerCallContext context)
    {
        //var coupon = request.Coupon.Adapt<Coupon>();
        //if (coupon is null)
        //    throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid request object."));

        //dbContext.Coupons.Update(coupon);
        //await dbContext.SaveChangesAsync();

        //logger.LogInformation("Discount is successfully updated. ProductName : {ProductName}", coupon.ProductName);

        //var couponModel = coupon.Adapt<CouponModel>();
        //return couponModel;
        return base.UpdateDiscount(request, context);
    }

    public override Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
    {
        //var coupon = await dbContext
        //    .Coupons
        //    .FirstOrDefaultAsync(x => x.ProductName == request.ProductName);

        //if (coupon is null)
        //    throw new RpcException(new Status(StatusCode.NotFound, $"Discount with ProductName={request.ProductName} is not found."));

        //dbContext.Coupons.Remove(coupon);
        //await dbContext.SaveChangesAsync();

        //logger.LogInformation("Discount is successfully deleted. ProductName : {ProductName}", request.ProductName);

        //return new DeleteDiscountResponse { Success = true };
        return base.DeleteDiscount(request, context);
    }
}
