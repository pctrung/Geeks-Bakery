import { yupResolver } from "@hookform/resolvers/yup";
import { useState, useEffect } from "react";
import { useForm, useWatch } from "react-hook-form";
import {
  Alert,
  Button,
  Card,
  CardBody,
  CardHeader,
  Col,
  Form,
  FormGroup,
  Row,
} from "reactstrap";
import * as yup from "yup";
import MyModal from "../../components/Customs/MyModal.js";
import imageApi from "../../api/imageApi.js";

export default function ImageCreate(props) {
  const [cakeImages, setCakeImages] = useState([{}]);

  const [stateMessage, setStateMessage] = useState({
    isOpen: false,
    color: "",
    message: "",
  });
  const [isChanged, setIsChanged] = useState(false);

  const schema = yup.object().shape({
    Images: yup.array().of(
      yup.object().shape({
        ImageFile: yup
          .mixed()
          .required()
          .test("fileFormat", "You can only upload image files", (value) => {
            if (typeof value !== "undefined") {
              if (value.length > 0) {
                var isValid = true;
                if (!value[0].type.includes("image")) {
                  isValid = false;
                }
                return isValid;
              }
            }
            return true;
          }),
      }),
    ),
  });
  // react  hook form
  const {
    register,
    handleSubmit,
    control,
    reset,
    formState: { errors },
  } = useForm({
    resolver: yupResolver(schema),
    defaultValues: {
      Images: cakeImages?.map((image) => {
        return {
          Caption: image.Caption,
          IsDefault: image.IsDefault,
          SortOrder: image.SortOrder,
          CakeId: image.CakeId,
          ImageFile: "",
        };
      }),
    },
  });
  const watchImage = useWatch({
    control,
    name: "Images",
  });
  function onUpdateChange() {
    var result = false;

    if (watchImage) {
      result = watchImage.some(
        (image, index) =>
          image?.ImageFile !== "" ||
          image?.Caption !== cakeImages[index]?.Caption ||
          image?.IsDefault !== cakeImages[index]?.IsDefault ||
          image?.SortOrder !== cakeImages[index]?.SortOrder,
      );
    }
    setIsChanged(result);
  }
  const onSubmit = async (content) => {
    var isUploadSuccess = true;
    if (content && props.cakeId) {
      if (content.Images?.length > 0) {
        content.Images.forEach(async (image, index) => {
          var updateImage = new FormData();

          updateImage.append("Id", cakeImages[index].Id);
          updateImage.append(
            "ImageFile",
            image.ImageFile !== "" ? image.ImageFile[0] : null,
          );
          updateImage.append("CakeId", props.cakeId);
          updateImage.append(
            "Caption",
            image.Caption ? image.Caption : "Cake Image",
          );
          updateImage.append(
            "SortOrder",
            image.SortOrder ? image.SortOrder : 1,
          );
          updateImage.append("IsDefault", image.IsDefault);

          var result = await imageApi.updateAsync(updateImage);
          if (!result) {
            isUploadSuccess = false;
          }
        });
      }
    }
    if (isUploadSuccess) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: "Update cake image successfully",
      });
      await props.refreshPage(props.cakeId);
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Update cake image failed",
      });
    }
  };

  useEffect(() => {
    onUpdateChange(); // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [watchImage]);

  useEffect(() => {
    if (props.cakeImages) {
      setCakeImages(props.cakeImages);
      reset({
        Images: cakeImages?.map((image) => {
          return {
            Caption: image.Caption,
            IsDefault: image.IsDefault,
            SortOrder: image.SortOrder,
            CakeId: image.CakeId,
            ImageFile: "",
          };
        }),
      });
    }
  }, [props]);

  // delete feature
  const [deleteModal, setDeleteModal] = useState({
    isOpen: false,
    content: "",
    deleteId: 0,
  });

  function toggleDeleteModal(id = 0, name = "") {
    if (id !== 0 && name !== "") {
      setDeleteModal({
        isOpen: !deleteModal.isOpen,
        content: name,
        deleteId: id,
      });
    } else {
      setDeleteModal({
        isOpen: !deleteModal.isOpen,
        content: deleteModal.content,
        deleteId: deleteModal.deleteId,
      });
    }
  }

  async function deleteHandler() {
    var id = deleteModal.deleteId;
    var cakeId = props.cakeId;

    var isDeleted = await imageApi.deleteAsync(id, cakeId);
    if (isDeleted) {
      setStateMessage({
        isOpen: true,
        color: "success",
        message: `Delete image ${deleteModal.content} successfully`,
      });
      await props.refreshPage(props.cakeId);
    } else {
      setStateMessage({
        isOpen: true,
        color: "danger",
        message: "Delete image failed",
      });
    }

    setDeleteModal({
      isOpen: !deleteModal.isOpen,
      content: deleteModal.content,
      deleteId: deleteModal.id,
    });
  }

  return (
    <>
      <MyModal
        modal={deleteModal.isOpen}
        toggle={toggleDeleteModal}
        handler={deleteHandler}
        content={`Do you want to delete ${deleteModal.content}?`}
        color="danger"
        confirm="Delete"
      ></MyModal>
      {/* Page content */}
      <Row className="mt-2">
        <Col className="mb-5 mb-xl-0" xl="12">
          <Card>
            <CardHeader>
              <Row className="align-items-center">
                <div className="col">
                  <h3 className="mb-0">Update image</h3>
                </div>
              </Row>
            </CardHeader>
            <Alert
              color={stateMessage.color}
              isOpen={stateMessage.isOpen}
              toggle={() => setStateMessage({ isOpen: false })}
            >
              {stateMessage.message}
            </Alert>
            <CardBody>
              <Form onSubmit={handleSubmit(onSubmit)}>
                <div className="pl-lg-4">
                  {cakeImages
                    ?.sort((a, b) => a.SortOrder + b.SortOrder)
                    .map((image, index) => (
                      <div key={image.id}>
                        <FormGroup>
                          <label className="form-control-label">
                            Image {index + 1}
                          </label>
                          <input
                            className="form-control"
                            type="file"
                            {...register(`Images.${index}.ImageFile`)}
                          />

                          <div
                            style={{ fontSize: 13 }}
                            className="text-danger fw-light mx-1 mt-2"
                          >
                            {typeof errors.Images !== "undefined"
                              ? errors.Images[index]?.ImageFile?.message
                              : ""}
                          </div>
                        </FormGroup>
                        <img
                          className="img-thumbnail rounded mb-2"
                          style={{ width: 150 }}
                          src={image.FileUrl}
                          alt={image.Caption}
                        />
                        <Button
                          outline
                          className="ml-4"
                          onClick={() =>
                            toggleDeleteModal(image.Id, image.Caption)
                          }
                          color="danger"
                        >
                          Delete
                        </Button>
                        <Row>
                          <Col lg="6">
                            <FormGroup>
                              <label className="form-control-label">
                                Caption (for alt image - SEO)
                              </label>
                              <input
                                className="form-control"
                                type="text"
                                placeholder="Ex: Chocolate Cake Image"
                                {...register(`Images.${index}.Caption`)}
                              />
                              <div
                                style={{ fontSize: 13 }}
                                className="text-danger fw-light mx-1 mt-2"
                              >
                                {typeof errors.Images !== "undefined"
                                  ? errors.Images[index]?.Caption?.message
                                  : ""}
                              </div>
                            </FormGroup>
                          </Col>
                          <Col lg="6">
                            <Row>
                              <FormGroup className="col-6">
                                <label className="form-control-label">
                                  Sort order
                                </label>
                                <input
                                  className="form-control"
                                  type="number"
                                  {...register(`Images.${index}.SortOrder`)}
                                />
                                <div
                                  style={{ fontSize: 13 }}
                                  className="text-danger fw-light mx-1 mt-2"
                                >
                                  {typeof errors.Images !== "undefined"
                                    ? errors.Images[index]?.SortOrder?.message
                                    : ""}
                                </div>
                              </FormGroup>
                              <FormGroup className="col-6 d-flex flex-column align-items-start">
                                <label className="form-control-label">
                                  Default Image
                                </label>
                                <label className="custom-toggle mt-2">
                                  <input
                                    type="checkbox"
                                    {...register(`Images.${index}.IsDefault`)}
                                  />
                                  <span className="custom-toggle-slider rounded-circle"></span>
                                </label>
                                <div
                                  style={{ fontSize: 13 }}
                                  className="text-danger fw-light mx-1 mt-2"
                                >
                                  {typeof errors.Images !== "undefined"
                                    ? errors.Images[index]?.IsDefault?.message
                                    : ""}
                                </div>
                              </FormGroup>
                            </Row>
                          </Col>
                        </Row>
                        <hr />
                      </div>
                    ))}
                  <FormGroup>
                    <Button
                      disabled={!isChanged}
                      className={"float-right "}
                      color="success"
                    >
                      Update
                    </Button>
                  </FormGroup>
                </div>
              </Form>
            </CardBody>
          </Card>
        </Col>
      </Row>
    </>
  );
}
