using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XLActionController
{
	[Static]
	partial interface Constants
	{
		// extern double XLActionControllerVersionNumber;
		[Field("XLActionControllerVersionNumber", "__Internal")]
		double XLActionControllerVersionNumber { get; }

		// extern const unsigned char [] XLActionControllerVersionString;
		[Field("XLActionControllerVersionString", "__Internal")]
		IntPtr XLActionControllerVersionString { get; }
	}

	// @interface ActionCell : UICollectionViewCell
	[BaseType(typeof(UICollectionViewCell))]
	interface ActionCell
	{
		// @property (nonatomic, weak) UILabel * _Nullable actionTitleLabel __attribute__((iboutlet));
		[NullAllowed, Export("actionTitleLabel", ArgumentSemantic.Weak)]
		UILabel ActionTitleLabel { get; set; }

		// @property (nonatomic, weak) UIImageView * _Nullable actionImageView __attribute__((iboutlet));
		[NullAllowed, Export("actionImageView", ArgumentSemantic.Weak)]
		UIImageView ActionImageView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable actionDetailLabel __attribute__((iboutlet));
		[NullAllowed, Export("actionDetailLabel", ArgumentSemantic.Weak)]
		UILabel ActionDetailLabel { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable separatorView __attribute__((iboutlet));
		[NullAllowed, Export("separatorView", ArgumentSemantic.Weak)]
		UIView SeparatorView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * _Nullable imageViewWidthConstraint __attribute__((iboutlet));
		[NullAllowed, Export("imageViewWidthConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint ImageViewWidthConstraint { get; set; }

		// -(void)awakeFromNib __attribute__((objc_requires_super));
		[Export("awakeFromNib")]
		//[RequiresSuper]
		void AwakeFromNib();

		// -(void)setup:(NSString * _Nullable)title detail:(NSString * _Nullable)detail image:(UIImage * _Nullable)image;
		[Export("setup:detail:image:")]
		void Setup([NullAllowed] string title, [NullAllowed] string detail, [NullAllowed] UIImage image);

		// -(void)showSeparator;
		[Export("showSeparator")]
		void ShowSeparator();

		// -(void)hideSeparator;
		[Export("hideSeparator")]
		void HideSeparator();

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export("initWithFrame:")]
		//[DesignatedInitializer]
		IntPtr Constructor(CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);
	}

	// @interface DynamicCollectionViewFlowLayout : UICollectionViewFlowLayout
	[BaseType(typeof(UICollectionViewFlowLayout))]
	[DisableDefaultCtor]
	interface DynamicCollectionViewFlowLayout
	{
		// @property (nonatomic, strong) UIDynamicAnimator * _Nullable dynamicAnimator;
		[NullAllowed, Export("dynamicAnimator", ArgumentSemantic.Strong)]
		UIDynamicAnimator DynamicAnimator { get; set; }

		// @property (nonatomic) UIControlContentHorizontalAlignment itemsAligment;
		[Export("itemsAligment", ArgumentSemantic.Assign)]
		UIControlContentHorizontalAlignment ItemsAligment { get; set; }

		// @property (nonatomic, strong) UICollisionBehavior * _Nullable collisionBehavior;
		[NullAllowed, Export("collisionBehavior", ArgumentSemantic.Strong)]
		UICollisionBehavior CollisionBehavior { get; set; }

		// @property (nonatomic, strong) UIDynamicItemBehavior * _Nullable dynamicItemBehavior;
		[NullAllowed, Export("dynamicItemBehavior", ArgumentSemantic.Strong)]
		UIDynamicItemBehavior DynamicItemBehavior { get; set; }

		// @property (nonatomic, strong) UIGravityBehavior * _Nullable gravityBehavior;
		[NullAllowed, Export("gravityBehavior", ArgumentSemantic.Strong)]
		UIGravityBehavior GravityBehavior { get; set; }

		// @property (nonatomic) BOOL useDynamicAnimator;
		[Export("useDynamicAnimator")]
		bool UseDynamicAnimator { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(NSArray<UICollectionViewLayoutAttributes *> * _Nullable)layoutAttributesForElementsInRect:(CGRect)rect __attribute__((warn_unused_result));
		[Export("layoutAttributesForElementsInRect:")]
		[return: NullAllowed]
		UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect(CGRect rect);

		// -(UICollectionViewLayoutAttributes * _Nullable)layoutAttributesForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
		[Export("layoutAttributesForItemAtIndexPath:")]
		[return: NullAllowed]
		UICollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath(NSIndexPath indexPath);

		// -(void)prepareForCollectionViewUpdates:(NSArray<UICollectionViewUpdateItem *> * _Nonnull)updateItems;
		[Export("prepareForCollectionViewUpdates:")]
		void PrepareForCollectionViewUpdates(UICollectionViewUpdateItem[] updateItems);

		// -(BOOL)shouldInvalidateLayoutForBoundsChange:(CGRect)newBounds __attribute__((warn_unused_result));
		[Export("shouldInvalidateLayoutForBoundsChange:")]
		bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds);
	}
}
